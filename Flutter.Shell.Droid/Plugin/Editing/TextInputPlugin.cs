using Android.App;
using Android.Content;
using Android.Text;
using Android.Views.InputMethods;
using Flutter.Shell.Droid.Plugin.Common;
using Flutter.Shell.Droid.View;
using Java.Lang;
using Org.Json;
using Result = Flutter.Shell.Droid.Plugin.Common.Result;

namespace Flutter.Shell.Droid.Plugin.Editing
{
    /**
     * Android implementation of the text input plugin.
     */
    public class TextInputPlugin : MethodCallHandler
    {
        private readonly FlutterView mView;
        private readonly InputMethodManager mImm;
        private MethodChannel mFlutterChannel;
        private int mClient = 0;
        private JSONObject mConfiguration;
        private IEditable mEditable;
        private bool mRestartInputPending;

        public TextInputPlugin(FlutterView view)
        {
            mView = view;
            mImm = (InputMethodManager)view.Context.GetSystemService(Context.InputMethodService);
            mFlutterChannel = new MethodChannel(view, "flutter/textinput", StandardMethodCodec.INSTANCE); // JSONMethodCodec.INSTANCE);
            mFlutterChannel.SetMethodCallHandler(this);
        }

        //@Override
        public void OnMethodCall(MethodCall call, Result result)
        {
            string method = call.Method;
            object args = call.Arguments;
            try
            {
                if (method.Equals("TextInput.show"))
                {
                    ShowTextInput(mView);
                    result.Success(null);
                }
                else if (method.Equals("TextInput.hide"))
                {
                    HideTextInput(mView);
                    result.Success(null);
                }
                else if (method.Equals("TextInput.setClient"))
                {
                    JSONArray argumentList = (JSONArray)args;
                    SetTextInputClient(mView, argumentList.GetInt(0), argumentList.GetJSONObject(1));
                    result.Success(null);
                }
                else if (method.Equals("TextInput.setEditingState"))
                {
                    SetTextInputEditingState(mView, (JSONObject)args);
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
                if (type.OptBoolean("signed")) numTextType |= InputTypes.NumberFlagSigned;
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
            if (mClient == 0) return null;

            outAttrs.InputType = InputTypeFromTextInputType(mConfiguration.GetJSONObject("inputType"),
                mConfiguration.OptBoolean("obscureText"),
                mConfiguration.OptBoolean("autocorrect", true),
                mConfiguration.GetString("textCapitalization"));
            outAttrs.ImeOptions = ImeFlags.NoFullscreen;
            ImeAction enterAction;
            if (mConfiguration.IsNull("inputAction"))
            {
                // If an explicit input action isn't set, then default to none for multi-line fields
                // and done for single line fields.
                enterAction = (InputTypes.TextFlagMultiLine & outAttrs.InputType) != 0 ? ImeAction.None : ImeAction.Done;
            }
            else
            {
                enterAction = InputActionFromTextInputAction(mConfiguration.GetString("inputAction"));
            }
            if (!mConfiguration.IsNull("actionLabel"))
            {
                outAttrs.ActionLabel = new String(mConfiguration.GetString("actionLabel"));
                outAttrs.ActionId = (int)enterAction;
            }
            outAttrs.ImeOptions = (ImeFlags)((int)outAttrs.ImeOptions | (int)enterAction);

            InputConnectionAdaptor connection = new InputConnectionAdaptor(
                view, 
                mClient, 
                mFlutterChannel, 
                mEditable);
            outAttrs.InitialSelStart = Selection.GetSelectionStart(mEditable);
            outAttrs.InitialSelEnd = Selection.GetSelectionEnd(mEditable);

            return connection;
        }

        private void ShowTextInput(FlutterView view)
        {
            view.RequestFocus();
            mImm.ShowSoftInput(view, 0);
        }

        private void HideTextInput(FlutterView view)
        {
            mImm.HideSoftInputFromWindow(view.ApplicationWindowToken, 0);
        }

        private void SetTextInputClient(FlutterView view, int client, JSONObject configuration)
        {
            mClient = client;
            mConfiguration = configuration;
            mEditable = EditableFactory.Instance.NewEditable("");

            // setTextInputClient will be followed by a call to setTextInputEditingState.
            // Do a restartInput at that time.
            mRestartInputPending = true;
        }

        private void ApplyStateToSelection(JSONObject state)
        {
            int selStart = state.GetInt("selectionBase");
            int selEnd = state.GetInt("selectionExtent");
            if (selStart >= 0 && selStart <= mEditable.Length() && selEnd >= 0
                    && selEnd <= mEditable.Length())
            {
                Selection.SetSelection(mEditable, selStart, selEnd);
            }
            else
            {
                Selection.RemoveSelection(mEditable);
            }
        }

        private void SetTextInputEditingState(FlutterView view, JSONObject state)
        {
            if (!mRestartInputPending && state.GetString("text").Equals(mEditable.ToString()))
            {
                ApplyStateToSelection(state);
                mImm.UpdateSelection(mView, Math.Max(Selection.GetSelectionStart(mEditable), 0),
                        Math.Max(Selection.GetSelectionEnd(mEditable), 0),
                        BaseInputConnection.GetComposingSpanStart(mEditable),
                        BaseInputConnection.GetComposingSpanEnd(mEditable));
            }
            else
            {
                mEditable.Replace(0, mEditable.Length(), state.GetString("text"));
                ApplyStateToSelection(state);
                mImm.RestartInput(view);
                mRestartInputPending = false;
            }
        }

        private void ClearTextInputClient()
        {
            mClient = 0;
        }
    }
}