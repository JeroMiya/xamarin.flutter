using Android.Content;
using Android.Text;
using Android.Views;
using Android.Views.InputMethods;
using Flutter.Shell.Droid.Plugin.Common;
using Flutter.Shell.Droid.View;
using Java.Lang;
using System.Collections.Generic;
using Math = System.Math;

namespace Flutter.Shell.Droid.Plugin.Editing
{
    public class InputConnectionAdaptor : BaseInputConnection
    {
        private readonly FlutterView _flutterView;
        private readonly int _client;
        private readonly MethodChannel _flutterChannel;
        private readonly IEditable _editable;
        private int _batchCount;
        private readonly InputMethodManager _imm;

        public InputConnectionAdaptor(
            FlutterView view,
            int client,
            MethodChannel flutterChannel,
            IEditable editable) : base(view, true)
        {
            _flutterView    = view;
            _client         = client;
            _flutterChannel = flutterChannel;
            _editable       = editable;
            _batchCount     = 0;
            _imm            = (InputMethodManager)view.Context.GetSystemService(Context.InputMethodService);
        }

        // Send the current state of the editable to Flutter.
        private void UpdateEditingState()
        {
            // If the IME is in the middle of a batch edit, then wait until it completes.
            if (_batchCount > 0)
                return;

            int selectionStart = Selection.GetSelectionStart(_editable);
            int selectionEnd = Selection.GetSelectionEnd(_editable);
            int composingStart = GetComposingSpanStart(_editable);
            int composingEnd = GetComposingSpanEnd(_editable);

            _imm.UpdateSelection(
                _flutterView,
                selectionStart,
                selectionEnd,
                composingStart,
                composingEnd);

            Dictionary<string, object> state = new Dictionary<string, object>
            {
                {"text", _editable.ToString()},
                {"selectionBase", selectionStart},
                {"selectionExtent", selectionEnd},
                {"composingBase", composingStart},
                {"composingExtent", composingEnd}
            };
            _flutterChannel.InvokeMethod("TextInputClient.updateEditingState", new object[] {_client, state});
        }

        //@Override
        public IEditable GetEditable()
        {
            return _editable;
        }

        //@Override
        public override bool BeginBatchEdit()
        {
            _batchCount++;
            return base.BeginBatchEdit();
        }

        //@Override
        public override bool EndBatchEdit()
        {
            bool result = base.EndBatchEdit();
            _batchCount--;
            UpdateEditingState();
            return result;
        }

        //@Override
        public override bool CommitText(ICharSequence text, int newCursorPosition)
        {
            bool result = base.CommitText(text, newCursorPosition);
            UpdateEditingState();
            return result;
        }

        //@Override
        public override bool DeleteSurroundingText(int beforeLength, int afterLength)
        {
            if (Selection.GetSelectionStart(_editable) == -1)
                return true;

            bool result = base.DeleteSurroundingText(beforeLength, afterLength);
            UpdateEditingState();
            return result;
        }

        //@Override
        public override bool SetComposingRegion(int start, int end)
        {
            bool result = base.SetComposingRegion(start, end);
            UpdateEditingState();
            return result;
        }

        //@Override
        public new bool SetComposingText(string text, int newCursorPosition)
        {
            bool result;
            if (text.Length == 0)
            {
                result = base.CommitText(text, newCursorPosition);
            }
            else
            {
                result = base.SetComposingText(text, newCursorPosition);
            }

            UpdateEditingState();
            return result;
        }

        //@Override
        public override bool SetSelection(int start, int end)
        {
            bool result = base.SetSelection(start, end);
            UpdateEditingState();
            return result;
        }

        //@Override
        public override bool SendKeyEvent(KeyEvent @event)
        {
            if (@event.Action == KeyEventActions.Down)
            {
                if (@event.KeyCode == Keycode.Del)
                {
                    int selStart = Selection.GetSelectionStart(_editable);
                    int selEnd = Selection.GetSelectionEnd(_editable);
                    if (selEnd > selStart)
                    {
                        // Delete the selection.
                        Selection.SetSelection(_editable, selStart);
                        _editable.Delete(selStart, selEnd);
                        UpdateEditingState();
                        return true;
                    }

                    if (selStart > 0)
                    {
                        // Delete to the left of the cursor.
                        int newSel = Math.Max(selStart - 1, 0);
                        Selection.SetSelection(_editable, newSel);
                        _editable.Delete(newSel, selStart);
                        UpdateEditingState();
                        return true;
                    }
                }
                else if (@event.KeyCode == Keycode.DpadLeft)
                {
                    int selStart = Selection.GetSelectionStart(_editable);
                    int newSel = Math.Max(selStart - 1, 0);
                    SetSelection(newSel, newSel);
                    return true;
                }
                else if (@event.KeyCode == Keycode.DpadRight)
                {
                    int selStart = Selection.GetSelectionStart(_editable);
                    int newSel = Math.Min(selStart + 1, _editable.Length());
                    SetSelection(newSel, newSel);
                    return true;
                }
                else
                {
                    // Enter a character.
                    int character = @event.UnicodeChar;
                    if (character != 0)
                    {
                        int selStart = Math.Max(0, Selection.GetSelectionStart(_editable));
                        int selEnd = Math.Max(0, Selection.GetSelectionEnd(_editable));
                        if (selEnd != selStart)
                            _editable.Delete(selStart, selEnd);
                        _editable.Insert(selStart, ((char)character).ToString());
                        SetSelection(selStart + 1, selStart + 1);
                        UpdateEditingState();
                    }

                    return true;
                }
            }

            return false;
        }

        //@Override
        public override bool PerformEditorAction(ImeAction actionCode)
        {
            switch (actionCode)
            {
            // TODO(mattcarroll): is newline an appropriate action for "none"?
            case ImeAction.None:
                _flutterChannel.InvokeMethod("TextInputClient.performAction", new object[] {_client, "TextInputAction.newline"});
                break;
            case ImeAction.Unspecified:
                _flutterChannel.InvokeMethod("TextInputClient.performAction", new object[] {_client, "TextInputAction.unspecified"});
                break;
            case ImeAction.Go:
                _flutterChannel.InvokeMethod("TextInputClient.performAction", new object[] {_client, "TextInputAction.go"});
                break;
            case ImeAction.Search:
                _flutterChannel.InvokeMethod("TextInputClient.performAction", new object[] {_client, "TextInputAction.search"});
                break;
            case ImeAction.Send:
                _flutterChannel.InvokeMethod("TextInputClient.performAction", new object[] {_client, "TextInputAction.send"});
                break;
            case ImeAction.Next:
                _flutterChannel.InvokeMethod("TextInputClient.performAction", new object[] {_client, "TextInputAction.next"});
                break;
            case ImeAction.Previous:
                _flutterChannel.InvokeMethod("TextInputClient.performAction", new object[] {_client, "TextInputAction.previous"});
                break;
            case ImeAction.Done:
            default:
                _flutterChannel.InvokeMethod("TextInputClient.performAction", new object[] {_client, "TextInputAction.done"});
                break;
            }

            return true;
        }
    }
}
