using Android.App;
using Android.Content;
using Android.Text;
using Android.Views.InputMethods;
using Flutter.Shell.Droid.Plugin.Common;
using Flutter.Shell.Droid.View;
using FlutterBinding.Plugin.Common;
using Java.Lang;
using Org.Json;

namespace Flutter.Shell.Droid.Plugin.Editing
{
    /// <summary>Android implementation of the text input plugin.</summary>
    public class TextInputPlugin : IMethodCallHandler
    {
        private readonly FlutterView _view;
        private readonly InputMethodManager _imm;
        private MethodChannel _flutterChannel;
        private int _client = 0;
        private JSONObject _configuration;
        private IEditable _editable;
        private bool _restartInputPending;

        public TextInputPlugin(FlutterView view)
        {
            _view           = view;
            _imm            = (InputMethodManager)view.Context.GetSystemService(Context.InputMethodService);
            _flutterChannel = new MethodChannel(view, "flutter/textinput", StandardMethodCodec.Instance); // JSONMethodCodec.INSTANCE);
            _flutterChannel.SetMethodCallHandler(this);
        }

        //@Override
        public void OnMethodCall(MethodCall call, IResult result)
        {
            string method = call.Method;
            object args = call.Arguments;
            try
            {
                if (method.Equals("TextInput.show"))
                {
                    ShowTextInput(_view);
                    result.Success(null);
                }
                else if (method.Equals("TextInput.hide"))
                {
                    HideTextInput(_view);
                    result.Success(null);
                }
                else if (method.Equals("TextInput.setClient"))
                {
                    JSONArray argumentList = (JSONArray)args;
                    SetTextInputClient(_view, argumentList.GetInt(0), argumentList.GetJSONObject(1));
                    result.Success(null);
                }
                else if (method.Equals("TextInput.setEditingState"))
                {
                    SetTextInputEditingState(_view, (JSONObject)args);
                    result.Success(null);
                }
                else if (method.Equals("TextInput.clearClient"))
                {
                    ClearTextInputClient();
                    result.Success(null);
                }
                else
                {
                    result.NotImplemented();
                }
            }
            catch (JSONException e)
            {
                result.Error("error", "JSON error: " + e.Message, null);
            }
        }

        private static InputTypes InputTypeFromTextInputType(
            JSONObject type,
            bool obscureText,
            bool autocorrect,
            string textCapitalization)
        {
            string inputType = type.GetString("name");
            if (inputType.Equals("TextInputType.datetime"))
                return InputTypes.ClassDatetime;

            if (inputType.Equals("TextInputType.number"))
            {
                InputTypes numTextType = InputTypes.ClassNumber;
                if (type.OptBoolean("signed")) numTextType  |= InputTypes.NumberFlagSigned;
                if (type.OptBoolean("decimal")) numTextType |= InputTypes.NumberFlagDecimal;
                return numTextType;
            }

            if (inputType.Equals("TextInputType.phone"))
                return InputTypes.ClassPhone;

            InputTypes textType = InputTypes.ClassText;
            if (inputType.Equals("TextInputType.multiline"))
                textType |= InputTypes.TextFlagMultiLine;
            else if (inputType.Equals("TextInputType.emailAddress"))
                textType |= InputTypes.TextVariationEmailAddress;
            else if (inputType.Equals("TextInputType.url"))
                textType |= InputTypes.TextVariationUri;
            if (obscureText)
            {
                // Note: both required. Some devices ignore TYPE_TEXT_FLAG_NO_SUGGESTIONS.
                textType |= InputTypes.TextFlagNoSuggestions;
                textType |= InputTypes.TextVariationPassword;
            }
            else if (autocorrect)
                textType |= InputTypes.TextFlagAutoCorrect;

            if (textCapitalization.Equals("TextCapitalization.characters"))
                textType |= InputTypes.TextFlagCapCharacters;
            else if (textCapitalization.Equals("TextCapitalization.words"))
                textType |= InputTypes.TextFlagCapWords;
            else if (textCapitalization.Equals("TextCapitalization.sentences"))
                textType |= InputTypes.TextFlagCapSentences;

            return textType;
        }

        private static ImeAction InputActionFromTextInputAction(string inputAction)
        {
            switch (inputAction)
            {
            case "TextInputAction.newline":
                return ImeAction.None;
            case "TextInputAction.none":
                return ImeAction.None;
            case "TextInputAction.unspecified":
                return ImeAction.Unspecified;
            case "TextInputAction.done":
                return ImeAction.Done;
            case "TextInputAction.go":
                return ImeAction.Go;
            case "TextInputAction.search":
                return ImeAction.Search;
            case "TextInputAction.send":
                return ImeAction.Send;
            case "TextInputAction.next":
                return ImeAction.Next;
            case "TextInputAction.previous":
                return ImeAction.Previous;
            default:
                // Present default key if bad input type is given.
                return ImeAction.Unspecified;
            }
        }

        public IInputConnection CreateInputConnection(FlutterView view, EditorInfo outAttrs)
        {
            if (_client == 0) return null;

            outAttrs.InputType = InputTypeFromTextInputType(
                _configuration.GetJSONObject("inputType"),
                _configuration.OptBoolean("obscureText"),
                _configuration.OptBoolean("autocorrect", true),
                _configuration.GetString("textCapitalization"));
            outAttrs.ImeOptions = ImeFlags.NoFullscreen;
            ImeAction enterAction;
            if (_configuration.IsNull("inputAction"))
            {
                // If an explicit input action isn't set, then default to none for multi-line fields
                // and done for single line fields.
                enterAction = (InputTypes.TextFlagMultiLine & outAttrs.InputType) != 0 ? ImeAction.None : ImeAction.Done;
            }
            else
            {
                enterAction = InputActionFromTextInputAction(_configuration.GetString("inputAction"));
            }

            if (!_configuration.IsNull("actionLabel"))
            {
                outAttrs.ActionLabel = new String(_configuration.GetString("actionLabel"));
                outAttrs.ActionId    = (int)enterAction;
            }

            outAttrs.ImeOptions = (ImeFlags)((int)outAttrs.ImeOptions | (int)enterAction);

            InputConnectionAdaptor connection = new InputConnectionAdaptor(
                view,
                _client,
                _flutterChannel,
                _editable);
            outAttrs.InitialSelStart = Selection.GetSelectionStart(_editable);
            outAttrs.InitialSelEnd   = Selection.GetSelectionEnd(_editable);

            return connection;
        }

        private void ShowTextInput(FlutterView view)
        {
            view.RequestFocus();
            _imm.ShowSoftInput(view, 0);
        }

        private void HideTextInput(FlutterView view)
        {
            _imm.HideSoftInputFromWindow(view.ApplicationWindowToken, 0);
        }

        private void SetTextInputClient(FlutterView view, int client, JSONObject configuration)
        {
            _client        = client;
            _configuration = configuration;
            _editable      = EditableFactory.Instance.NewEditable("");

            // setTextInputClient will be followed by a call to setTextInputEditingState.
            // Do a restartInput at that time.
            _restartInputPending = true;
        }

        private void ApplyStateToSelection(JSONObject state)
        {
            int selStart = state.GetInt("selectionBase");
            int selEnd = state.GetInt("selectionExtent");
            if (selStart >= 0 && selStart <= _editable.Length() && selEnd >= 0
                && selEnd <= _editable.Length())
            {
                Selection.SetSelection(_editable, selStart, selEnd);
            }
            else
            {
                Selection.RemoveSelection(_editable);
            }
        }

        private void SetTextInputEditingState(FlutterView view, JSONObject state)
        {
            if (!_restartInputPending && state.GetString("text").Equals(_editable.ToString()))
            {
                ApplyStateToSelection(state);
                _imm.UpdateSelection(
                    _view,
                    Math.Max(Selection.GetSelectionStart(_editable), 0),
                    Math.Max(Selection.GetSelectionEnd(_editable), 0),
                    BaseInputConnection.GetComposingSpanStart(_editable),
                    BaseInputConnection.GetComposingSpanEnd(_editable));
            }
            else
            {
                _editable.Replace(0, _editable.Length(), state.GetString("text"));
                ApplyStateToSelection(state);
                _imm.RestartInput(view);
                _restartInputPending = false;
            }
        }

        private void ClearTextInputClient()
        {
            _client = 0;
        }
    }
}
