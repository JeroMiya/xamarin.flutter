using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Util;
using Android.Views;
using Flutter.Shell.Droid.Plugin.Common;
using Org.Json;

namespace Flutter.Shell.Droid.Plugin.Platform
{
    /**
     * Android implementation of the platform plugin.
     */
    public class PlatformPlugin : IMethodCallHandler, IActivityLifecycleListener
    {
        private SystemUiFlags _enabledOverlays;
        private readonly Activity _activity;
        private JSONObject _currentTheme;
        public static SystemUiFlags DEFAULT_SYSTEM_UI = SystemUiFlags.LayoutStable | SystemUiFlags.LayoutFullscreen;
        private const string TextPlainFormat = "text/plain";

        public PlatformPlugin(Activity activity)
        {
            _activity        = activity;
            _enabledOverlays = DEFAULT_SYSTEM_UI;
        }

        //@Override
        public void OnMethodCall(MethodCall call, IResult result)
        {
            string method = call.Method;
            object arguments = call.Arguments;
            try
            {
                if (method.Equals("SystemSound.play"))
                {
                    PlaySystemSound((string)arguments);
                    result.Success(null);
                }
                else if (method.Equals("HapticFeedback.vibrate"))
                {
                    VibrateHapticFeedback((string)arguments);
                    result.Success(null);
                }
                else if (method.Equals("SystemChrome.setPreferredOrientations"))
                {
                    SetSystemChromePreferredOrientations((JSONArray)arguments);
                    result.Success(null);
                }
                else if (method.Equals("SystemChrome.setApplicationSwitcherDescription"))
                {
                    SetSystemChromeApplicationSwitcherDescription((JSONObject)arguments);
                    result.Success(null);
                }
                else if (method.Equals("SystemChrome.setEnabledSystemUIOverlays"))
                {
                    SetSystemChromeEnabledSystemUiOverlays((JSONArray)arguments);
                    result.Success(null);
                }
                else if (method.Equals("SystemChrome.restoreSystemUIOverlays"))
                {
                    RestoreSystemChromeSystemUiOverlays();
                    result.Success(null);
                }
                else if (method.Equals("SystemChrome.setSystemUIOverlayStyle"))
                {
                    SetSystemChromeSystemUiOverlayStyle((JSONObject)arguments);
                    result.Success(null);
                }
                else if (method.Equals("SystemNavigator.pop"))
                {
                    PopSystemNavigator();
                    result.Success(null);
                }
                else if (method.Equals("Clipboard.getData"))
                {
                    result.Success(GetClipboardData((string)arguments));
                }
                else if (method.Equals("Clipboard.setData"))
                {
                    SetClipboardData((JSONObject)arguments);
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

        private void PlaySystemSound(string soundType)
        {
            if (soundType.Equals("SystemSoundType.click"))
            {
                Android.Views.View view = _activity.Window.DecorView;
                view.PlaySoundEffect(SoundEffects.Click);
            }
        }

        private void VibrateHapticFeedback(string feedbackType)
        {
            Android.Views.View view = _activity.Window.DecorView;
            if (feedbackType == null)
            {
                view.PerformHapticFeedback(FeedbackConstants.LongPress);
            }
            else if (feedbackType.Equals("HapticFeedbackType.lightImpact"))
            {
                view.PerformHapticFeedback(FeedbackConstants.VirtualKey);
            }
            else if (feedbackType.Equals("HapticFeedbackType.mediumImpact"))
            {
                view.PerformHapticFeedback(FeedbackConstants.KeyboardTap);
            }
            else if (feedbackType.Equals("HapticFeedbackType.heavyImpact"))
            {
                // HapticFeedbackConstants.CONTEXT_CLICK from API level 23.
                view.PerformHapticFeedback(FeedbackConstants.ContextClick);
            }
            else if (feedbackType.Equals("HapticFeedbackType.selectionClick"))
            {
                view.PerformHapticFeedback(FeedbackConstants.ClockTick);
            }
        }

        private void SetSystemChromePreferredOrientations(JSONArray orientations)
        {
            int requestedOrientation = 0x00;
            int firstRequestedOrientation = 0x00;
            for (int index = 0; index < orientations.Length(); index += 1)
            {
                if (orientations.GetString(index).Equals("DeviceOrientation.portraitUp"))
                {
                    requestedOrientation |= 0x01;
                }
                else if (orientations.GetString(index).Equals("DeviceOrientation.landscapeLeft"))
                {
                    requestedOrientation |= 0x02;
                }
                else if (orientations.GetString(index).Equals("DeviceOrientation.portraitDown"))
                {
                    requestedOrientation |= 0x04;
                }
                else if (orientations.GetString(index).Equals("DeviceOrientation.landscapeRight"))
                {
                    requestedOrientation |= 0x08;
                }

                if (firstRequestedOrientation == 0x00)
                {
                    firstRequestedOrientation = requestedOrientation;
                }
            }

            switch (requestedOrientation)
            {
            case 0x00:
                _activity.RequestedOrientation = ScreenOrientation.Unspecified;
                break;
            case 0x01:
                _activity.RequestedOrientation = ScreenOrientation.Portrait;
                break;
            case 0x02:
                _activity.RequestedOrientation = ScreenOrientation.Landscape;
                break;
            case 0x04:
                _activity.RequestedOrientation = ScreenOrientation.ReversePortrait;
                break;
            case 0x05:
                _activity.RequestedOrientation = ScreenOrientation.UserPortrait;
                break;
            case 0x08:
                _activity.RequestedOrientation = ScreenOrientation.ReverseLandscape;
                break;
            case 0x0a:
                _activity.RequestedOrientation = ScreenOrientation.UserLandscape;
                break;
            case 0x0b:
                _activity.RequestedOrientation = ScreenOrientation.User;
                break;
            case 0x0f:
                _activity.RequestedOrientation = ScreenOrientation.FullUser;
                break;
            case 0x03: // portraitUp and landscapeLeft
            case 0x06: // portraitDown and landscapeLeft
            case 0x07: // portraitUp, portraitDown, and landscapeLeft
            case 0x09: // portraitUp and landscapeRight
            case 0x0c: // portraitDown and landscapeRight
            case 0x0d: // portraitUp, portraitDown, and landscapeRight
            case 0x0e: // portraitDown, landscapeLeft, and landscapeRight
                // Android can't describe these cases, so just default to whatever the first
                // specified value was.
                switch (firstRequestedOrientation)
                {
                case 0x01:
                    _activity.RequestedOrientation = ScreenOrientation.Portrait;
                    break;
                case 0x02:
                    _activity.RequestedOrientation = ScreenOrientation.Landscape;
                    break;
                case 0x04:
                    _activity.RequestedOrientation = ScreenOrientation.ReversePortrait;
                    break;
                case 0x08:
                    _activity.RequestedOrientation = ScreenOrientation.ReverseLandscape;
                    break;
                }

                break;
            }
        }

        private void SetSystemChromeApplicationSwitcherDescription(JSONObject description)
        {
            if (Build.VERSION.SdkInt < BuildVersionCodes.Lollipop)
                return;

            int color = description.GetInt("primaryColor");
            if (color != 0)
            {                                            // 0 means color isn't set, use system default
                color = (int)((uint)color | 0xFF000000); // color must be opaque if set
            }

            _activity.SetTaskDescription(
                new ActivityManager.TaskDescription(
                    description.GetString("label"),
                    null,
                    new Color(color)
                )
            );
        }

        private void SetSystemChromeEnabledSystemUiOverlays(JSONArray overlays)
        {
            SystemUiFlags enabledOverlays = DEFAULT_SYSTEM_UI
                | SystemUiFlags.Fullscreen
                | SystemUiFlags.LayoutHideNavigation
                | SystemUiFlags.HideNavigation;

            if (overlays.Length() == 0)
                enabledOverlays |= SystemUiFlags.ImmersiveSticky;

            for (int i = 0; i < overlays.Length(); ++i)
            {
                string overlay = overlays.GetString(i);
                if (overlay.Equals("SystemUiOverlay.top"))
                    enabledOverlays &= ~SystemUiFlags.Fullscreen;
                else if (overlay.Equals("SystemUiOverlay.bottom"))
                    enabledOverlays &= ~(SystemUiFlags.LayoutHideNavigation | SystemUiFlags.HideNavigation);
            }

            _enabledOverlays = enabledOverlays;
            UpdateSystemUiOverlays();
        }

        private void UpdateSystemUiOverlays()
        {
            _activity.Window.DecorView.SystemUiVisibility = (StatusBarVisibility)_enabledOverlays;
            if (_currentTheme != null)
                SetSystemChromeSystemUiOverlayStyle(_currentTheme);
        }

        private void RestoreSystemChromeSystemUiOverlays()
        {
            UpdateSystemUiOverlays();
        }

        private void SetSystemChromeSystemUiOverlayStyle(JSONObject message)
        {
            Window window = _activity.Window;
            Android.Views.View view = window.DecorView;
            var flags = (SystemUiFlags)view.SystemUiVisibility;
            try
            {
                // You can change the navigation bar color (including translucent colors)
                // in Android, but you can't change the color of the navigation buttons until Android O.
                // LIGHT vs DARK effectively isn't supported until then.
                // Build.VERSION_CODES.O
                if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
                {
                    if (!message.IsNull("systemNavigationBarIconBrightness"))
                    {
                        string systemNavigationBarIconBrightness = message.GetString("systemNavigationBarIconBrightness");
                        switch (systemNavigationBarIconBrightness)
                        {
                        case "Brightness.dark":
                            flags |= SystemUiFlags.LightNavigationBar;
                            break;
                        case "Brightness.light":
                            flags &= ~(SystemUiFlags.LightNavigationBar);
                            break;
                        }
                    }

                    if (!message.IsNull("systemNavigationBarColor"))
                    {
                        var color = new Color(message.GetInt("systemNavigationBarColor"));
                        window.SetNavigationBarColor(color);
                    }
                }

                if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
                {
                    if (!message.IsNull("statusBarIconBrightness"))
                    {
                        string statusBarIconBrightness = message.GetString("statusBarIconBrightness");
                        switch (statusBarIconBrightness)
                        {
                        case "Brightness.dark":
                            // View.SYSTEM_UI_FLAG_LIGHT_STATUS_BAR
                            flags |= SystemUiFlags.LightStatusBar;
                            break;
                        case "Brightness.light":
                            flags &= ~(SystemUiFlags.LightStatusBar);
                            break;
                        }
                    }

                    if (!message.IsNull("statusBarColor"))
                    {
                        var color = new Color(message.GetInt("statusBarColor"));
                        window.SetStatusBarColor(color);
                    }
                }

                if (!message.IsNull("systemNavigationBarDividerColor"))
                {
                    if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
                    {
                        // Not available until Android P.
                        // window.setNavigationBarDividerColor(systemNavigationBarDividerColor);
                    }
                }

                view.SystemUiVisibility = (StatusBarVisibility)flags;
                _currentTheme           = message;
            }
            catch (JSONException err)
            {
                Log.Info("PlatformPlugin", err.ToString());
            }
        }

        private void PopSystemNavigator()
        {
            _activity.Finish();
        }

        private JSONObject GetClipboardData(string format)
        {
            ClipboardManager clipboard = (ClipboardManager)_activity.GetSystemService(Context.ClipboardService);
            ClipData clip = clipboard.PrimaryClip;
            if (clip == null)
                return null;

            if (format == null || format.Equals(TextPlainFormat))
            {
                JSONObject result = new JSONObject();
                result.Put("text", clip.GetItemAt(0).CoerceToText(_activity));
                return result;
            }

            return null;
        }

        private void SetClipboardData(JSONObject data)
        {
            ClipboardManager clipboard = (ClipboardManager)_activity.GetSystemService(Context.ClipboardService);
            ClipData clip = ClipData.NewPlainText("text label?", data.GetString("text"));
            clipboard.PrimaryClip = clip;
        }

        //@Override
        public void OnPostResume()
        {
            UpdateSystemUiOverlays();
        }
    }
}
