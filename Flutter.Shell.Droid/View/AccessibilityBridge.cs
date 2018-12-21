using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Views.Accessibility;
using Flutter.Shell.Droid.Plugin.Common;
using Flutter.Shell;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Android.Views;
using Java.Lang;
using Math = System.Math;
using Rect = Android.Graphics.Rect;
using Matrix = Android.Opengl.Matrix;

namespace Flutter.Shell.Droid.View
{
    public class AccessibilityBridge : AccessibilityNodeProvider, BasicMessageChannel<object>.MessageHandler<object>
    {
        private static readonly string TAG = "FlutterView";

        // Constants from higher API levels.
        // TODO(goderbauer): Get these from Android Support Library when
        // https://github.com/flutter/flutter/issues/11099 is resolved.
        private static readonly int ACTION_SHOW_ON_SCREEN = 16908342; // API level 23

        private static readonly float SCROLL_EXTENT_FOR_INFINITY = 100000.0f;
        private static readonly float SCROLL_POSITION_CAP_FOR_INFINITY = 70000.0f;
        private static readonly int ROOT_NODE_ID = 0;

        private Dictionary<int, SemanticsObject> mObjects;
        private Dictionary<int, CustomAccessibilityAction> mCustomAccessibilityActions;
        private FlutterView mOwner;
        private bool mAccessibilityEnabled = false;
        private SemanticsObject mA11yFocusedObject;
        private SemanticsObject mInputFocusedObject;
        private SemanticsObject mHoveredObject;
        private int previousRouteId = ROOT_NODE_ID;
        private List<int> previousRoutes;
        private Android.Views.View mDecorView;
        private int mLastLeftFrameInset = 0;

        private BasicMessageChannel<object> mFlutterAccessibilityChannel;


        [Flags]
        public enum Action
        {
            Unknown = 0,
            TAP = 1 << 0,
            LONG_PRESS = 1 << 1,
            SCROLL_LEFT = 1 << 2,
            SCROLL_RIGHT = 1 << 3,
            SCROLL_UP = 1 << 4,
            SCROLL_DOWN = 1 << 5,
            INCREASE = 1 << 6,
            DECREASE = 1 << 7,
            SHOW_ON_SCREEN = 1 << 8,
            MOVE_CURSOR_FORWARD_BY_CHARACTER = 1 << 9,
            MOVE_CURSOR_BACKWARD_BY_CHARACTER = 1 << 10,
            SET_SELECTION = 1 << 11,
            COPY = 1 << 12,
            CUT = 1 << 13,
            PASTE = 1 << 14,
            DID_GAIN_ACCESSIBILITY_FOCUS = 1 << 15,
            DID_LOSE_ACCESSIBILITY_FOCUS = 1 << 16,
            CUSTOM_ACTION = 1 << 17,
            DISMISS = 1 << 18,
            MOVE_CURSOR_FORWARD_BY_WORD = 1 << 19,
            MOVE_CURSOR_BACKWARD_BY_WORD = 1 << 20
        }

        public enum Flag
        {
            HAS_CHECKED_STATE = 1 << 0,
            IS_CHECKED = 1 << 1,
            IS_SELECTED = 1 << 2,
            IS_BUTTON = 1 << 3,
            IS_TEXT_FIELD = 1 << 4,
            IS_FOCUSED = 1 << 5,
            HAS_ENABLED_STATE = 1 << 6,
            IS_ENABLED = 1 << 7,
            IS_IN_MUTUALLY_EXCLUSIVE_GROUP = 1 << 8,
            IS_HEADER = 1 << 9,
            IS_OBSCURED = 1 << 10,
            SCOPES_ROUTE = 1 << 11,
            NAMES_ROUTE = 1 << 12,
            IS_HIDDEN = 1 << 13,
            IS_IMAGE = 1 << 14,
            IS_LIVE_REGION = 1 << 15,
            HAS_TOGGLED_STATE = 1 << 16,
            IS_TOGGLED = 1 << 17,
            HAS_IMPLICIT_SCROLLING = 1 << 18
        }

        public AccessibilityBridge(FlutterView owner)
        {
            //assert owner != null;
            mOwner = owner;
            mObjects = new Dictionary<int, SemanticsObject>();
            mCustomAccessibilityActions = new Dictionary<int, CustomAccessibilityAction>();
            previousRoutes = new List<int>();
            mFlutterAccessibilityChannel = new BasicMessageChannel<object>(
                owner,
                "flutter/accessibility",
                StandardMessageCodec.INSTANCE);
            mDecorView = ((Activity)owner.Context).Window.DecorView;
        }

        private void SetAccessibilityEnabled(bool accessibilityEnabled)
        {
            mAccessibilityEnabled = accessibilityEnabled;
            if (accessibilityEnabled)
            {
                mFlutterAccessibilityChannel.SetMessageHandler(this);
            }
            else
            {
                mFlutterAccessibilityChannel.SetMessageHandler(null);
            }
        }

        //@Override
        //@SuppressWarnings("deprecation")
        public override AccessibilityNodeInfo CreateAccessibilityNodeInfo(int virtualViewId)
        {
            if (virtualViewId == Android.Views.View.NoId)
            {
                AccessibilityNodeInfo aResult = AccessibilityNodeInfo.Obtain(mOwner);
                mOwner.OnInitializeAccessibilityNodeInfo(aResult);
                if (mObjects.ContainsKey(ROOT_NODE_ID))
                {
                    aResult.AddChild(mOwner, ROOT_NODE_ID);
                }

                return aResult;
            }

            SemanticsObject @object = mObjects[virtualViewId];
            if (@object == null)
            {
                return null;
            }

            AccessibilityNodeInfo result = AccessibilityNodeInfo.Obtain(mOwner, virtualViewId);
            // Work around for https://github.com/flutter/flutter/issues/2101
            if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBeanMr2)
            {
                result.ViewIdResourceName = "";
            }

            result.PackageName = mOwner.Context.PackageName;
            result.ClassName = "android.view.View";
            result.SetSource(mOwner, virtualViewId);
            result.Focusable = @object.IsFocusable;
            if (mInputFocusedObject != null)
            {
                result.Focused = mInputFocusedObject.Id == virtualViewId;
            }

            if (mA11yFocusedObject != null)
            {
                result.AccessibilityFocused = (mA11yFocusedObject.Id == virtualViewId);
            }

            if (@object.HasFlag(Flag.IS_TEXT_FIELD))
            {
                result.Password = @object.HasFlag(Flag.IS_OBSCURED);
                result.ClassName = "android.widget.EditText";
                if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBeanMr2)
                {
                    result.Editable = true;
                    if (@object.TextSelectionBase != -1 && @object.TextSelectionExtent != -1)
                    {
                        result.SetTextSelection(@object.TextSelectionBase, @object.TextSelectionExtent);
                    }

                    // Text fields will always be created as a live region when they have input focus,
                    // so that updates to the label trigger polite announcements. This makes it easy to
                    // follow a11y guidelines for text fields on Android.
                    if (Build.VERSION.SdkInt > BuildVersionCodes.JellyBeanMr2 && 
                        mA11yFocusedObject != null && 
                        mA11yFocusedObject.Id == virtualViewId)
                    {
                        result.LiveRegion = AccessibilityLiveRegion.Polite;
                    }
                }

                // Cursor movements
                MovementGranularity granularities = (MovementGranularity)0;
                if (@object.HasAction(Action.MOVE_CURSOR_FORWARD_BY_CHARACTER))
                {
                    result.AddAction(Android.Views.Accessibility.Action.NextAtMovementGranularity);
                    granularities |= MovementGranularity.Character;
                }

                if (@object.HasAction(Action.MOVE_CURSOR_BACKWARD_BY_CHARACTER))
                {
                    result.AddAction(Android.Views.Accessibility.Action.PreviousAtMovementGranularity);
                    granularities |= MovementGranularity.Character;
                }

                if (@object.HasAction(Action.MOVE_CURSOR_FORWARD_BY_WORD))
                {
                    result.AddAction(Android.Views.Accessibility.Action.NextAtMovementGranularity);
                    granularities |= MovementGranularity.Word;
                }

                if (@object.HasAction(Action.MOVE_CURSOR_BACKWARD_BY_WORD))
                {
                    result.AddAction(Android.Views.Accessibility.Action.PreviousAtMovementGranularity);
                    granularities |= MovementGranularity.Word;
                }

                result.MovementGranularities = granularities;
            }

            if (@object.HasAction(Action.SET_SELECTION))
            {
                result.AddAction(Android.Views.Accessibility.Action.SetSelection);
            }

            if (@object.HasAction(Action.COPY))
            {
                result.AddAction(Android.Views.Accessibility.Action.Copy);
            }

            if (@object.HasAction(Action.CUT))
            {
                result.AddAction(Android.Views.Accessibility.Action.Cut);
            }

            if (@object.HasAction(Action.PASTE))
            {
                result.AddAction(Android.Views.Accessibility.Action.Paste);
            }

            if (@object.HasFlag(Flag.IS_BUTTON))
            {
                result.ClassName = "android.widget.Button";
            }

            if (@object.HasFlag(Flag.IS_IMAGE))
            {
                result.ClassName = "android.widget.ImageView";
                // TODO(jonahwilliams): Figure out a way conform to the expected id from TalkBack's
                // CustomLabelManager. talkback/src/main/java/labeling/CustomLabelManager.java#L525
            }

            if (Build.VERSION.SdkInt > BuildVersionCodes.JellyBeanMr2 && @object.HasAction(Action.DISMISS))
            {
                result.Dismissable = true;
                result.AddAction(Android.Views.Accessibility.Action.Dismiss);
            }

            if (@object.parent != null)
            {
                //assert @object.Id > ROOT_NODE_ID;
                result.SetParent(mOwner, @object.parent.Id);
            }
            else
            {
                //assert @object.Id == ROOT_NODE_ID;
                result.SetParent(mOwner);
            }

            Rect bounds = @object.GetGlobalRect();
            if (@object.parent != null)
            {
                Rect parentBounds = @object.parent.GetGlobalRect();
                Rect boundsInParent = new Rect(bounds);
                boundsInParent.Offset(-parentBounds.Left, -parentBounds.Top);
                result.SetBoundsInParent(boundsInParent);
            }
            else
            {
                result.SetBoundsInParent(bounds);
            }

            result.SetBoundsInScreen(bounds);
            result.VisibleToUser = true;
            result.Enabled = !@object.HasFlag(Flag.HAS_ENABLED_STATE) || @object.HasFlag(Flag.IS_ENABLED);

            if (@object.HasAction(Action.TAP))
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop && @object.onTapOverride != null)
                {
                    result.AddAction(
                        new AccessibilityNodeInfo.AccessibilityAction(
                            (int)Android.Views.Accessibility.Action.Click, 
                            new Java.Lang.String(@object.onTapOverride.Hint)));
                    result.Clickable = true;
                }
                else
                {
                    result.AddAction(Android.Views.Accessibility.Action.Click);
                    result.Clickable = true;
                }
            }

            if (@object.HasAction(Action.LONG_PRESS))
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop && @object.onLongPressOverride != null)
                {
                    result.AddAction(
                        new AccessibilityNodeInfo.AccessibilityAction(
                            Android.Views.Accessibility.Action.LongClick,
                            new Java.Lang.String(@object.onLongPressOverride.Hint)));
                    result.LongClickable = true;
                }
                else
                {
                    result.AddAction(Android.Views.Accessibility.Action.LongClick);
                    result.LongClickable = true;
                }
            }

            if (@object.HasAction(Action.SCROLL_LEFT) || @object.HasAction(Action.SCROLL_UP)
                || @object.HasAction(Action.SCROLL_RIGHT) || @object.HasAction(Action.SCROLL_DOWN))
            {
                result.Scrollable = true;
                // This tells Android's a11y to send scroll events when reaching the end of
                // the visible viewport of a scrollable, unless the node itself does not
                // allow implicit scrolling - then we leave the className as view.View.
                if (@object.HasFlag(Flag.HAS_IMPLICIT_SCROLLING))
                {
                    if (@object.HasAction(Action.SCROLL_LEFT) || @object.HasAction(Action.SCROLL_RIGHT))
                    {
                        result.ClassName = "android.widget.HorizontalScrollView";
                    }
                    else
                    {
                        result.ClassName = "android.widget.ScrollView";
                    }
                }

                // TODO(ianh): Once we're on SDK v23+, call addAction to
                // expose AccessibilityAction.ACTION_SCROLL_LEFT, _RIGHT,
                // _UP, and _DOWN when appropriate.
                if (@object.HasAction(Action.SCROLL_LEFT) || @object.HasAction(Action.SCROLL_UP))
                {
                    result.AddAction(Android.Views.Accessibility.Action.ScrollForward);
                }

                if (@object.HasAction(Action.SCROLL_RIGHT) || @object.HasAction(Action.SCROLL_DOWN))
                {
                    result.AddAction(Android.Views.Accessibility.Action.ScrollBackward);
                }
            }

            if (@object.HasAction(Action.INCREASE) || @object.HasAction(Action.DECREASE))
            {
                // TODO(jonahwilliams): support AccessibilityAction.ACTION_SET_PROGRESS once SDK is
                // updated.
                result.ClassName = "android.widget.SeekBar";
                if (@object.HasAction(Action.INCREASE))
                {
                    result.AddAction(Android.Views.Accessibility.Action.ScrollForward);
                }

                if (@object.HasAction(Action.DECREASE))
                {
                    result.AddAction(Android.Views.Accessibility.Action.ScrollBackward);
                }
            }

            if (@object.HasFlag(Flag.IS_LIVE_REGION) && Build.VERSION.SdkInt > BuildVersionCodes.JellyBeanMr2)
            {
                result.LiveRegion = AccessibilityLiveRegion.Polite;
            }

            bool hasCheckedState = @object.HasFlag(Flag.HAS_CHECKED_STATE);
            bool hasToggledState = @object.HasFlag(Flag.HAS_TOGGLED_STATE);
            //assert !(hasCheckedState && hasToggledState);
            result.Checkable = (hasCheckedState || hasToggledState);
            if (hasCheckedState)
            {
                result.Checked = @object.HasFlag(Flag.IS_CHECKED);
                result.ContentDescription = @object.GetValueLabelHint();
                if (@object.HasFlag(Flag.IS_IN_MUTUALLY_EXCLUSIVE_GROUP))
                    result.ClassName = "android.widget.RadioButton";
                else
                    result.ClassName = "android.widget.CheckBox";
            }
            else if (hasToggledState)
            {
                result.Checked = @object.HasFlag(Flag.IS_TOGGLED);
                result.ClassName = "android.widget.Switch";
                result.ContentDescription = @object.GetValueLabelHint();
            }
            else
            {
                // Setting the text directly instead of the content description
                // will replace the "checked" or "not-checked" label.
                result.Text = @object.GetValueLabelHint();
            }

            result.Selected = @object.HasFlag(Flag.IS_SELECTED);

            // Accessibility Focus
            if (mA11yFocusedObject != null && mA11yFocusedObject.Id == virtualViewId)
            {
                result.AddAction( Android.Views.Accessibility.Action.ClearAccessibilityFocus);
            }
            else
            {
                result.AddAction(Android.Views.Accessibility.Action.AccessibilityFocus);
            }

            // Actions on the local context menu
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                if (@object.customAccessibilityActions != null)
                {
                    foreach (CustomAccessibilityAction action in @object.customAccessibilityActions)
                    {
                        result.AddAction(
                            new AccessibilityNodeInfo.AccessibilityAction(
                                action.ResourceId,
                                action.Label));
                    }
                }
            }

            if (@object.childrenInTraversalOrder != null)
            {
                foreach (SemanticsObject child in @object.childrenInTraversalOrder)
                {
                    if (!child.HasFlag(Flag.IS_HIDDEN))
                    {
                        result.AddChild(mOwner, child.Id);
                    }
                }
            }

            return result;
        }

        //@Override
        public override bool PerformAction(int virtualViewId, Android.Views.Accessibility.Action action, Bundle arguments)
        {
            SemanticsObject @object = mObjects[virtualViewId];
            if (@object == null)
            {
                return false;
            }

            switch (action)
            {
                case Android.Views.Accessibility.Action.Click:
                    {
                        // Note: TalkBack prior to Oreo doesn't use this handler and instead simulates a
                        //     click event at the center of the SemanticsNode. Other a11y services might go
                        //     through this handler though.
                        mOwner.DispatchSemanticsAction(virtualViewId, Action.TAP);
                        return true;
                    }
                case Android.Views.Accessibility.Action.LongClick:
                    {
                        // Note: TalkBack doesn't use this handler and instead simulates a long click event
                        //     at the center of the SemanticsNode. Other a11y services might go through this
                        //     handler though.
                        mOwner.DispatchSemanticsAction(virtualViewId, Action.LONG_PRESS);
                        return true;
                    }
                case Android.Views.Accessibility.Action.ScrollForward:
                    {
                        if (@object.HasAction(Action.SCROLL_UP))
                        {
                            mOwner.DispatchSemanticsAction(virtualViewId, Action.SCROLL_UP);
                        }
                        else if (@object.HasAction(Action.SCROLL_LEFT))
                        {
                            // TODO(ianh): bidi support using textDirection
                            mOwner.DispatchSemanticsAction(virtualViewId, Action.SCROLL_LEFT);
                        }
                        else if (@object.HasAction(Action.INCREASE))
                        {
                            @object.Value = @object.IncreasedValue;
                            // Event causes Android to read out the updated value.
                            SendAccessibilityEvent(virtualViewId, EventTypes.ViewSelected);
                            mOwner.DispatchSemanticsAction(virtualViewId, Action.INCREASE);
                        }
                        else
                        {
                            return false;
                        }

                        return true;
                    }
                case Android.Views.Accessibility.Action.ScrollBackward:
                    {
                        if (@object.HasAction(Action.SCROLL_DOWN))
                        {
                            mOwner.DispatchSemanticsAction(virtualViewId, Action.SCROLL_DOWN);
                        }
                        else if (@object.HasAction(Action.SCROLL_RIGHT))
                        {
                            // TODO(ianh): bidi support using textDirection
                            mOwner.DispatchSemanticsAction(virtualViewId, Action.SCROLL_RIGHT);
                        }
                        else if (@object.HasAction(Action.DECREASE))
                        {
                            @object.Value = @object.DecreasedValue;
                            // Event causes Android to read out the updated value.
                            SendAccessibilityEvent(virtualViewId, EventTypes.ViewSelected);
                            mOwner.DispatchSemanticsAction(virtualViewId, Action.DECREASE);
                        }
                        else
                        {
                            return false;
                        }

                        return true;
                    }
                case Android.Views.Accessibility.Action.PreviousAtMovementGranularity:
                    {
                        return PerformCursorMoveAction(@object, virtualViewId, arguments, false);
                    }
                case Android.Views.Accessibility.Action.NextAtMovementGranularity:
                    {
                        return PerformCursorMoveAction(@object, virtualViewId, arguments, true);
                    }
                case Android.Views.Accessibility.Action.ClearAccessibilityFocus:
                    {
                        mOwner.DispatchSemanticsAction(virtualViewId, Action.DID_LOSE_ACCESSIBILITY_FOCUS);
                        SendAccessibilityEvent(
                            virtualViewId,
                            EventTypes.ViewAccessibilityFocusCleared);
                        mA11yFocusedObject = null;
                        return true;
                    }
                case Android.Views.Accessibility.Action.AccessibilityFocus:
                    {
                        mOwner.DispatchSemanticsAction(virtualViewId, Action.DID_GAIN_ACCESSIBILITY_FOCUS);
                        SendAccessibilityEvent(
                            virtualViewId,
                            EventTypes.ViewAccessibilityFocused);
                        if (mA11yFocusedObject == null)
                        {
                            // When Android focuses a node, it doesn't invalidate the view.
                            // (It does when it sends ACTION_CLEAR_ACCESSIBILITY_FOCUS, so
                            // we only have to worry about this when the focused node is null.)
                            mOwner.Invalidate();
                        }

                        mA11yFocusedObject = @object;

                        if (@object.HasAction(Action.INCREASE) || @object.HasAction(Action.DECREASE))
                        {
                            // SeekBars only announce themselves after this event.
                            SendAccessibilityEvent(virtualViewId, EventTypes.ViewSelected);
                        }

                        return true;
                    }
                case (Android.Views.Accessibility.Action)(AccessibilityBridge.ACTION_SHOW_ON_SCREEN):
                    {
                        mOwner.DispatchSemanticsAction(virtualViewId, Action.SHOW_ON_SCREEN);
                        return true;
                    }
                case Android.Views.Accessibility.Action.SetSelection:
                    {
                        Dictionary<string, int> selection = new Dictionary<string, int>();
                        bool hasSelection = arguments != null
                            && arguments.ContainsKey( AccessibilityNodeInfo.ACTION_ARGUMENT_SELECTION_START_INT)
                            && arguments.ContainsKey(
                                AccessibilityNodeInfo.ACTION_ARGUMENT_SELECTION_END_INT);
                        if (hasSelection)
                        {
                            selection["base"] = arguments.GetInt(AccessibilityNodeInfo.ACTION_ARGUMENT_SELECTION_START_INT);
                            selection["extent"] = arguments.GetInt(AccessibilityNodeInfo.ACTION_ARGUMENT_SELECTION_END_INT);
                        }
                        else
                        {
                            // Clear the selection
                            selection["base"] = @object.TextSelectionExtent;
                            selection["extent"] = @object.TextSelectionExtent;
                        }

                        mOwner.DispatchSemanticsAction(virtualViewId, Action.SET_SELECTION, selection);
                        return true;
                    }
                case Android.Views.Accessibility.Action.Copy:
                    {
                        mOwner.DispatchSemanticsAction(virtualViewId, Action.COPY);
                        return true;
                    }
                case Android.Views.Accessibility.Action.Cut:
                    {
                        mOwner.DispatchSemanticsAction(virtualViewId, Action.CUT);
                        return true;
                    }
                case Android.Views.Accessibility.Action.Paste:
                    {
                        mOwner.DispatchSemanticsAction(virtualViewId, Action.PASTE);
                        return true;
                    }
                case Android.Views.Accessibility.Action.Dismiss:
                    {
                        mOwner.DispatchSemanticsAction(virtualViewId, Action.DISMISS);
                        return true;
                    }
                default:
                    // might be a custom accessibility action.
                    int flutterId = (int)action - firstResourceId;
                    CustomAccessibilityAction contextAction = mCustomAccessibilityActions[flutterId];
                    if (contextAction != null)
                    {
                        mOwner.DispatchSemanticsAction(
                            virtualViewId,
                            Action.CUSTOM_ACTION,
                            contextAction.Id);
                        return true;
                    }

                    break;
            }

            return false;
        }

        private bool PerformCursorMoveAction(SemanticsObject @object, int virtualViewId, Bundle arguments, bool forward)
        {
            int granularity = arguments.GetInt( AccessibilityNodeInfo.ACTION_ARGUMENT_MOVEMENT_GRANULARITY_INT);
            bool extendSelection = arguments.GetBoolean( AccessibilityNodeInfo.ACTION_ARGUMENT_EXTEND_SELECTION_BOOLEAN);
            switch (granularity)
            {
                case AccessibilityNodeInfo.MOVEMENT_GRANULARITY_CHARACTER:
                    {
                        if (forward && @object.HasAction(Action.MOVE_CURSOR_FORWARD_BY_CHARACTER))
                        {
                            mOwner.DispatchSemanticsAction(
                                virtualViewId,
                                Action.MOVE_CURSOR_FORWARD_BY_CHARACTER,
                                extendSelection);
                            return true;
                        }

                        if (!forward && @object.HasAction(Action.MOVE_CURSOR_BACKWARD_BY_CHARACTER))
                        {
                            mOwner.DispatchSemanticsAction(
                                virtualViewId,
                                Action.MOVE_CURSOR_BACKWARD_BY_CHARACTER,
                                extendSelection);
                            return true;
                        }

                        break;
                    }
                case AccessibilityNodeInfo.MOVEMENT_GRANULARITY_WORD:
                    if (forward && @object.HasAction(Action.MOVE_CURSOR_FORWARD_BY_WORD))
                    {
                        mOwner.DispatchSemanticsAction(
                            virtualViewId,
                            Action.MOVE_CURSOR_FORWARD_BY_WORD,
                            extendSelection);
                        return true;
                    }

                    if (!forward && @object.HasAction(Action.MOVE_CURSOR_BACKWARD_BY_WORD))
                    {
                        mOwner.DispatchSemanticsAction(
                            virtualViewId,
                            Action.MOVE_CURSOR_BACKWARD_BY_WORD,
                            extendSelection);
                        return true;
                    }

                    break;
            }

            return false;
        }

        // TODO(ianh): implement findAccessibilityNodeInfosByText()

        //@Override
        public AccessibilityNodeInfo FindFocus(int focus)
        {
            switch (focus)
            {
                case AccessibilityNodeInfo.FOCUS_INPUT:
                    {
                        if (mInputFocusedObject != null)
                            return CreateAccessibilityNodeInfo(mInputFocusedObject.Id);
                    }
                // Fall through to check FOCUS_ACCESSIBILITY
                case AccessibilityNodeInfo.FOCUS_ACCESSIBILITY:
                    {
                        if (mA11yFocusedObject != null)
                            return CreateAccessibilityNodeInfo(mA11yFocusedObject.Id);
                    }
            }

            return null;
        }

        private SemanticsObject GetRootObject()
        {
            //assert mObjects.containsKey(0);
            return mObjects[0];
        }

        private SemanticsObject GetOrCreateObject(int id)
        {
            SemanticsObject @object = mObjects[id];
            if (@object == null)
            {
                @object = new SemanticsObject
                {
                    Id = id
                };
                mObjects[id] = @object;
            }

            return @object;
        }

        private CustomAccessibilityAction GetOrCreateAction(int id)
        {
            CustomAccessibilityAction action = mCustomAccessibilityActions[id];
            if (action == null)
            {
                action = new CustomAccessibilityAction
                {
                    Id = id,
                    ResourceId = id + firstResourceId
                };
                mCustomAccessibilityActions[id] = action;
            }

            return action;
        }

        private void HandleTouchExplorationExit()
        {
            if (mHoveredObject != null)
            {
                SendAccessibilityEvent(mHoveredObject.Id, EventTypes.ViewHoverExit);
                mHoveredObject = null;
            }
        }

        private void HandleTouchExploration(float x, float y)
        {
            if (mObjects.Count == 0)
                return;

            SemanticsObject newObject = GetRootObject().HitTest(new float[] { x, y, 0, 1 });
            if (newObject != mHoveredObject)
            {
                // sending ENTER before EXIT is how Android wants it
                if (newObject != null)
                {
                    SendAccessibilityEvent(newObject.Id, EventTypes.ViewHoverEnter);
                }

                if (mHoveredObject != null)
                {
                    SendAccessibilityEvent(mHoveredObject.Id, EventTypes.ViewHoverExit);
                }

                mHoveredObject = newObject;
            }
        }

        // TODO: ByteBuffer->object
        private void UpdateCustomAccessibilityActions(object buffer, string[] strings)
        {
            var list = (List<CustomAccessibilityAction>)buffer;
            foreach (var action in list)
            {
                CustomAccessibilityAction origAction = GetOrCreateAction(action.Id);
                origAction.OverrideId = action.OverrideId;
                origAction.Label = action.Label;
                origAction.Hint = action.Hint;
            }
        }

        // TODO: ByteBuffer->object
        private void UpdateSemantics(object buffer, string[] strings)
        {
            var updated = new List<SemanticsObject>();

            var list = (List<SemanticsParameter>)buffer;
            foreach (var parameter in list)
            {
                SemanticsObject @object = GetOrCreateObject(parameter.Id);
                @object.UpdateWith(parameter, strings);
                if (@object.HasFlag(Flag.IS_HIDDEN))
                    continue;

                if (@object.HasFlag(Flag.IS_FOCUSED))
                    mInputFocusedObject = @object;

                if (@object.HadPreviousConfig)
                    updated.Add(@object);

            }

            List<SemanticsObject> visitedObjects = new List<SemanticsObject>();
            SemanticsObject rootObject = GetRootObject();
            List<SemanticsObject> newRoutes = new List<SemanticsObject>();
            if (rootObject != null)
            {
                float[] identity = new float[16];
                Matrix.SetIdentityM(identity, 0);
                // in android devices API 23 and above, the system nav bar can be placed on the left side
                // of the screen in landscape mode. We must handle the translation ourselves for the
                // a11y nodes.
                if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
                {
                    Rect visibleFrame = new Rect();
                    mDecorView.GetWindowVisibleDisplayFrame(visibleFrame);
                    if (!mLastLeftFrameInset.Equals(visibleFrame.Left))
                    {
                        rootObject.globalGeometryDirty = true;
                        rootObject.inverseTransformDirty = true;
                    }

                    mLastLeftFrameInset = visibleFrame.Left;
                    Matrix.TranslateM(identity, 0, visibleFrame.Left, 0, 0);
                }

                rootObject.UpdateRecursively(identity, visitedObjects, false);
                rootObject.CollectRoutes(newRoutes);
            }

            // Dispatch a TYPE_WINDOW_STATE_CHANGED event if the most recent route id changed from the
            // previously cached route id.
            SemanticsObject lastAdded = null;
            foreach (SemanticsObject semanticsObject in newRoutes)
            {
                if (!previousRoutes.Contains(semanticsObject.Id))
                {
                    lastAdded = semanticsObject;
                }
            }
            if (lastAdded == null && newRoutes.Count > 0)
            {
                lastAdded = newRoutes[newRoutes.Count - 1];
            }

            if (lastAdded != null && lastAdded.Id != previousRouteId)
            {
                previousRouteId = lastAdded.Id;
                CreateWindowChangeEvent(lastAdded);
            }

            previousRoutes.Clear();
            foreach (SemanticsObject semanticsObject in newRoutes)
            {
                previousRoutes.Add(semanticsObject.Id);
            }

            foreach (var entry in mObjects.ToList())
            {
                SemanticsObject @object = entry.Value;
                if (!visitedObjects.Contains(@object))
                {
                    WillRemoveSemanticsObject(@object);
                    mObjects.Remove(entry.Key); //it.remove();
                }
            }

            // TODO(goderbauer): Send this event only once (!) for changed subtrees,
            //     see https://github.com/flutter/flutter/issues/14534
            SendAccessibilityEvent(0, EventTypes.WindowContentChanged);

            foreach (SemanticsObject @object in updated)
            {
                if (@object.DidScroll())
                {
                    AccessibilityEvent @event =
                        ObtainAccessibilityEvent(@object.Id, EventTypes.ViewScrolled);

                    // Android doesn't support unbound scrolling. So we pretend there is a large
                    // bound (SCROLL_EXTENT_FOR_INFINITY), which you can never reach.
                    float position = @object.ScrollPosition;
                    float max = @object.ScrollExtentMax;
                    if (!Float.IsFinite(@object.ScrollExtentMax))
                    {
                        max = SCROLL_EXTENT_FOR_INFINITY;
                        if (position > SCROLL_POSITION_CAP_FOR_INFINITY)
                        {
                            position = SCROLL_POSITION_CAP_FOR_INFINITY;
                        }
                    }

                    if (!Float.IsFinite(@object.ScrollExtentMin))
                    {
                        max += SCROLL_EXTENT_FOR_INFINITY;
                        if (position < -SCROLL_POSITION_CAP_FOR_INFINITY)
                        {
                            position = -SCROLL_POSITION_CAP_FOR_INFINITY;
                        }

                        position += SCROLL_EXTENT_FOR_INFINITY;
                    }
                    else
                    {
                        max -= @object.ScrollExtentMin;
                        position -= @object.ScrollExtentMin;
                    }

                    if (@object.HadAction(Action.SCROLL_UP) || @object.HadAction(Action.SCROLL_DOWN))
                    {
                        @event.ScrollY = (int)position;
                        @event.MaxScrollY = (int)max;
                    }
                    else if (@object.HadAction(Action.SCROLL_LEFT)
                        || @object.HadAction(Action.SCROLL_RIGHT))
                    {
                        @event.ScrollX = (int)position;
                        @event.MaxScrollX = (int)max;
                    }

                    if (@object.ScrollChildren > 0)
                    {
                        // We don't need to add 1 to the scroll index because TalkBack does this automagically.
                        @event.ItemCount = @object.ScrollChildren;
                        @event.FromIndex = @object.ScrollIndex;
                        int visibleChildren = 0;
                        // handle hidden children at the beginning and end of the list.
                        foreach (SemanticsObject child in @object.childrenInHitTestOrder)
                        {
                            if (!child.HasFlag(Flag.IS_HIDDEN))
                            {
                                visibleChildren += 1;
                            }
                        }

                        //assert(@object.ScrollIndex + visibleChildren <= @object.ScrollChildren);
                        //assert(!@object.childrenInHitTestOrder[@object.ScrollIndex].HasFlag(Flag.IS_HIDDEN));
                        // The setToIndex should be the index of the last visible child. Because we counted all
                        // children, including the first index we need to subtract one.
                        //
                        //   [0, 1, 2, 3, 4, 5]
                        //    ^     ^
                        // In the example above where 0 is the first visible index and 2 is the last, we will
                        // count 3 total visible children. We then subtract one to get the correct last visible
                        // index of 2.
                        @event.ToIndex = @object.ScrollIndex + visibleChildren - 1;
                    }

                    SendAccessibilityEvent(@event);
                }

                if (@object.HasFlag(Flag.IS_LIVE_REGION))
                {
                    string label = @object.Label == null ? "" : @object.Label;
                    string previousLabel = @object.Previous?.Label ?? @object.Label;
                    if (!label.Equals(previousLabel) || !@object.HadFlag(Flag.IS_LIVE_REGION))
                    {
                        SendAccessibilityEvent(@object.Id, EventTypes.WindowContentChanged);
                    }
                }
                else if (@object.HasFlag(Flag.IS_TEXT_FIELD) && @object.DidChangeLabel()
                    && mInputFocusedObject != null && mInputFocusedObject.Id == @object.Id)
                {
                    // Text fields should announce when their label changes while focused. We use a live
                    // region tag to do so, and this event triggers that update.
                    SendAccessibilityEvent(@object.Id, EventTypes.WindowContentChanged);
                }

                if (mA11yFocusedObject != null && mA11yFocusedObject.Id == @object.Id
                    && !@object.HadFlag(Flag.IS_SELECTED) && @object.HasFlag(Flag.IS_SELECTED))
                {
                    AccessibilityEvent @event =
                        ObtainAccessibilityEvent(@object.Id, EventTypes.ViewSelected);
                    @event.Text.Add(new Java.Lang.String(@object.Label));
                    SendAccessibilityEvent(@event);
                }

                if (mInputFocusedObject != null && mInputFocusedObject.Id == @object.Id
                    && @object.HadFlag(Flag.IS_TEXT_FIELD) && @object.HasFlag(Flag.IS_TEXT_FIELD)
                    // If we have a TextField that has InputFocus, we should avoid announcing it if something
                    // else we track has a11y focus. This needs to still work when, e.g., IME has a11y focus
                    // or the "PASTE" popup is used though.
                    // See more discussion at https://github.com/flutter/flutter/issues/23180
                    && (mA11yFocusedObject == null || (mA11yFocusedObject.Id == mInputFocusedObject.Id)))
                {
                    string oldValue = @object.Previous?.Value ?? "";
                    string newValue = @object.Value ?? "";
                    AccessibilityEvent @event = CreateTextChangedEvent(@object.Id, oldValue, newValue);
                    if (@event != null)
                    {
                        SendAccessibilityEvent(@event);
                    }

                    if (@object.Previous.TextSelectionBase != @object.TextSelectionBase
                        || @object.Previous.TextSelectionExtent != @object.TextSelectionExtent)
                    {
                        AccessibilityEvent selectionEvent = ObtainAccessibilityEvent(
                            @object.Id, EventTypes.ViewTextSelectionChanged);
                        selectionEvent.Text.Add(new Java.Lang.String(newValue));
                        selectionEvent.FromIndex = @object.TextSelectionBase;
                        selectionEvent.ToIndex = @object.TextSelectionExtent;
                        selectionEvent.ItemCount = newValue.Length;
                        SendAccessibilityEvent(selectionEvent);
                    }
                }
            }
        }

        private AccessibilityEvent CreateTextChangedEvent(int id, string oldValue, string newValue)
        {
            AccessibilityEvent e = ObtainAccessibilityEvent(id, EventTypes.ViewTextChanged);
            e.BeforeText = oldValue;
            e.Text.Add(new Java.Lang.String(newValue));

            int i;
            for (i = 0; i < oldValue.Length && i < newValue.Length; ++i)
            {
                if (oldValue[i] != newValue[i])
                    break;
            }

            if (i >= oldValue.Length && i >= newValue.Length)
                return null; // Text did not change

            int firstDifference = i;
            e.FromIndex = firstDifference;

            int oldIndex = oldValue.Length - 1;
            int newIndex = newValue.Length - 1;
            while (oldIndex >= firstDifference && newIndex >= firstDifference)
            {
                if (oldValue[oldIndex] != newValue[newIndex])
                    break;

                --oldIndex;
                --newIndex;
            }

            e.RemovedCount = oldIndex - firstDifference + 1;
            e.AddedCount = newIndex - firstDifference + 1;

            return e;
        }

        private AccessibilityEvent ObtainAccessibilityEvent(int virtualViewId, EventTypes eventType)
        {
            //assert virtualViewId != ROOT_NODE_ID;
            AccessibilityEvent @event = AccessibilityEvent.Obtain(eventType);
            @event.PackageName = mOwner.Context.PackageName;
            @event.SetSource(mOwner, virtualViewId);
            return @event;
        }

        private void SendAccessibilityEvent(int virtualViewId, EventTypes eventType)
        {
            if (!mAccessibilityEnabled)
            {
                return;
            }

            if (virtualViewId == ROOT_NODE_ID)
            {
                mOwner.SendAccessibilityEvent(eventType);
            }
            else
            {
                SendAccessibilityEvent(ObtainAccessibilityEvent(virtualViewId, eventType));
            }
        }

        private void SendAccessibilityEvent(AccessibilityEvent @event)
        {
            if (!mAccessibilityEnabled)
            {
                return;
            }

            mOwner.Parent.RequestSendAccessibilityEvent(mOwner, @event);
        }

        // Message Handler for [mFlutterAccessibilityChannel].
        public void OnMessage(object message, BasicMessageChannel<object>.Reply<object> reply)
        {
            //@SuppressWarnings("unchecked")
            var annotatedEvent = (Dictionary<string, object>)message;
            string type = (string)annotatedEvent["type"];
            //@SuppressWarnings("unchecked")
            var data = (Dictionary<string, object>)annotatedEvent["data"];

            switch (type)
            {
                case "announce":
                    mOwner.AnnounceForAccessibility((string)data["message"]);
                    break;
                case "longPress":
                    {
                        int nodeId = (int)annotatedEvent["nodeId"];

                        SendAccessibilityEvent(nodeId, EventTypes.ViewLongClicked);
                        break;
                    }
                case "tap":
                    {
                        int nodeId = (int)annotatedEvent["nodeId"];

                        SendAccessibilityEvent(nodeId, EventTypes.ViewClicked);
                        break;
                    }
                case "tooltip":
                    {
                        AccessibilityEvent e = ObtainAccessibilityEvent(
                            ROOT_NODE_ID,
                            EventTypes.WindowStateChanged);
                        e.Text.Add( new Java.Lang.String((string)data["message"] ));
                        SendAccessibilityEvent(e);
                        break;
                    }
            }
        }

        private void CreateWindowChangeEvent(SemanticsObject route)
        {
            AccessibilityEvent e = ObtainAccessibilityEvent(route.Id, EventTypes.WindowStateChanged);
            var routeName = new Java.Lang.String(route.GetRouteName());
            e.Text.Add(routeName);
            SendAccessibilityEvent(e);
        }

        private void WillRemoveSemanticsObject(SemanticsObject @object)
        {
            //assert mObjects.containsKey(@object.Id);
            //assert mObjects.get(@object.Id) == object;
            @object.parent = null;
            if (mA11yFocusedObject == @object)
            {
                SendAccessibilityEvent(
                    mA11yFocusedObject.Id,
                    EventTypes.ViewAccessibilityFocusCleared);
                mA11yFocusedObject = null;
            }

            if (mInputFocusedObject == @object)
            {
                mInputFocusedObject = null;
            }

            if (mHoveredObject == @object)
            {
                mHoveredObject = null;
            }
        }

        private void Reset()
        {
            mObjects.Clear();
            if (mA11yFocusedObject != null)
                SendAccessibilityEvent(
                    mA11yFocusedObject.Id,
                    EventTypes.ViewAccessibilityFocusCleared);
            mA11yFocusedObject = null;
            mHoveredObject = null;
            SendAccessibilityEvent(0, EventTypes.WindowContentChanged);
        }

        public enum TextDirection
        {
            UNKNOWN,
            LTR = 2,
            RTL = 1
        }

        private class CustomAccessibilityAction
        {
            public CustomAccessibilityAction() { }

            /// Resource id is the id of the custom action plus a minimum value so that the identifier
            /// does not collide with existing Android accessibility actions.
            public int ResourceId = -1;
            public int Id = -1;
            public Action OverrideId = Action.Unknown;

            /// The label is the user presented value which is displayed in the local context menu.
            public string Label;

            /// The hint is the text used in overriden standard actions.
            public string Hint;

            public bool IsStandardAction => OverrideId != Action.Unknown;
            
        }

        /// Value is derived from ACTION_TYPE_MASK in AccessibilityNodeInfo.java
        private static readonly int firstResourceId = 267386881;

        public class SemanticsParameter
        {
            public int Id;
            public Flag Flags;
            public Action Actions;
            public int TextSelectionBase;
            public int TextSelectionExtent;
            public int ScrollChildren;
            public int ScrollIndex;
            public float ScrollPosition;
            public float ScrollExtentMax;
            public float ScrollExtentMin;

            public string Label;
            public string Value;
            public string IncreasedValue;
            public string DecreasedValue;
            public string Hint;

            public TextDirection TextDirection;

            public float Left;
            public float Top;
            public float Right;
            public float Bottom;
            public float[] Transform;

            public List<int> ChildrenInTraversalOrder;
            public List<int> ChildrenInHitTestOrder;
            public List<int> CustomAccessibilityActions;
        }

        private class SemanticsObject
        {
            public SemanticsObject() { }

            public int Id = -1;
            public Flag Flags;
            public Action Actions;
            public int TextSelectionBase;
            public int TextSelectionExtent;
            public int ScrollChildren;
            public int ScrollIndex;
            public float ScrollPosition;
            public float ScrollExtentMax;
            public float ScrollExtentMin;
            public string Label;
            public string Value;
            public string IncreasedValue;
            public string DecreasedValue;
            public string Hint;
            public TextDirection TextDirection;
            public bool HadPreviousConfig = false;

            public SemanticsParameter Previous = new SemanticsParameter();

            private float left;
            private float top;
            private float right;
            private float bottom;
            private float[] transform;

            public SemanticsObject parent;
            public List<SemanticsObject> childrenInTraversalOrder;
            public List<SemanticsObject> childrenInHitTestOrder;
            public List<CustomAccessibilityAction> customAccessibilityActions;
            public CustomAccessibilityAction onTapOverride;
            public CustomAccessibilityAction onLongPressOverride;

            public bool inverseTransformDirty = true;
            private float[] inverseTransform;

            public bool globalGeometryDirty = true;
            public float[] globalTransform;
            public Rect globalRect;

            public bool HasAction(Action action)
            {
                return Actions.HasFlag(action);
            }

            public bool HadAction(Action action)
            {
                return Previous.Actions.HasFlag(action);
            }

            public bool HasFlag(Flag flag)
            {
                return Flags.HasFlag(flag);
            }

            public bool HadFlag(Flag flag)
            {
                //assert hadPreviousConfig;
                return Previous.Flags.HasFlag(flag);
            }

            public bool DidScroll()
            {
                return !float.IsNaN(ScrollPosition) && !float.IsNaN(Previous.ScrollPosition)
                    && Previous.ScrollPosition != ScrollPosition;
            }

            public bool DidChangeLabel()
            {
                if (Label == null && Previous.Label == null)
                {
                    return false;
                }

                return Label == null || Previous.Label == null || !Label.Equals(Previous.Label);
            }

            public void Log(string indent, bool recursive)
            {
                Android.Util.Log.Info(
                    TAG,
                    indent + "SemanticsObject id=" + Id + " label=" + Label + " actions=" + Actions
                    + " flags=" + Flags + "\n" + indent + "  +-- textDirection="
                    + TextDirection + "\n" + indent + "  +-- rect.ltrb=(" + left + ", "
                    + top + ", " + right + ", " + bottom + ")\n" + indent
                    + "  +-- transform=" + transform.ToDisplay() + "\n");
                
                if (childrenInTraversalOrder != null && recursive)
                {
                    string childIndent = indent + "  ";
                    foreach (SemanticsObject child in childrenInTraversalOrder)
                    {
                        child.Log(childIndent, recursive);
                    }
                }
            }

            // TODO: ByteBuffer->object
            public void UpdateWith(object buffer, string[] strings)
            {
                HadPreviousConfig = true;
                Previous = new SemanticsParameter
                {
                    Value = Value,
                    Label = Label,
                    Flags = Flags,
                    Actions = Actions,
                    TextSelectionBase = TextSelectionBase,
                    TextSelectionExtent = TextSelectionExtent,
                    ScrollPosition = ScrollPosition,
                    ScrollExtentMax = ScrollExtentMax,
                    ScrollExtentMin = ScrollExtentMin
                };

                var parameter = (SemanticsParameter)buffer;

                Flags = parameter.Flags;
                Actions = parameter.Actions;
                TextSelectionBase = parameter.TextSelectionBase;
                TextSelectionExtent = parameter.TextSelectionExtent;
                ScrollChildren = parameter.ScrollChildren;
                ScrollIndex = parameter.ScrollIndex;
                ScrollPosition = parameter.ScrollPosition;
                ScrollExtentMax = parameter.ScrollExtentMax;
                ScrollExtentMin = parameter.ScrollExtentMin;

                Label = parameter.Label;
                Value = parameter.Value;
                IncreasedValue = parameter.IncreasedValue;
                DecreasedValue = parameter.DecreasedValue;
                Hint = parameter.Hint;
                TextDirection = parameter.TextDirection;

                left = parameter.Left;
                top = parameter.Top;
                right = parameter.Right;
                bottom = parameter.Bottom;
                transform = parameter.Transform;

                inverseTransformDirty = true;
                globalGeometryDirty = true;

                childrenInTraversalOrder = new FlutterSDK.List<SemanticsObject>();
                childrenInHitTestOrder   = new FlutterSDK.List<SemanticsObject>();

                foreach (var id in parameter.ChildrenInTraversalOrder)
                {
                    SemanticsObject child = GetOrCreateObject(id);
                    child.parent = this;
                    childrenInTraversalOrder.Add(child);
                }

                foreach (var id in parameter.ChildrenInHitTestOrder)
                {
                    SemanticsObject child = GetOrCreateObject(id);
                    child.parent = this;
                    childrenInHitTestOrder.Add(child);
                }

                customAccessibilityActions = new FlutterSDK.List<CustomAccessibilityAction>();
                foreach (var id in parameter.CustomAccessibilityActions)
                {
                    CustomAccessibilityAction action = GetOrCreateAction(id);
                    if (action.OverrideId == Action.TAP)
                    {
                        onTapOverride = action;
                    }
                    else if (action.OverrideId == Action.LONG_PRESS)
                    {
                        onLongPressOverride = action;
                    }
                    else
                    {
                        // If we recieve a different overrideId it means that we were passed
                        // a standard action to override that we don't yet support.
                        //assert action.overrideId == -1;
                        customAccessibilityActions.Add(action);
                    }

                    customAccessibilityActions.Add(action);
                }
            }

            private void EnsureInverseTransform()
            {
                if (!inverseTransformDirty)
                {
                    return;
                }

                inverseTransformDirty = false;
                if (inverseTransform == null)
                {
                    inverseTransform = new float[16];
                }

                if (!Matrix.InvertM(inverseTransform, 0, transform, 0))
                {
                    Array.Fill(inverseTransform, 0);
                }
            }

            public Rect GetGlobalRect()
            {
                //assert !globalGeometryDirty;
                return globalRect;
            }

            public SemanticsObject HitTest(float[] point)
            {
                float w = point[3];
                float x = point[0] / w;
                float y = point[1] / w;
                if (x < left || x >= right || y < top || y >= bottom) return null;
                if (childrenInHitTestOrder != null)
                {
                    float[] transformedPoint = new float[4];
                    foreach (SemanticsObject child in childrenInHitTestOrder)
                    {
                        if (child.HasFlag(Flag.IS_HIDDEN))
                            continue;

                        child.EnsureInverseTransform();
                        Matrix.MultiplyMV(transformedPoint, 0, child.inverseTransform, 0, point, 0);
                        SemanticsObject result = child.HitTest(transformedPoint);
                        if (result != null)
                        {
                            return result;
                        }
                    }
                }

                return this;
            }

            // TODO(goderbauer): This should be decided by the framework once we have more information about focusability there.
            public bool IsFocusable
            {
                get
                {
                    // We enforce in the framework that no other useful semantics are merged with these
                    // nodes.
                    if (HasFlag(Flag.SCOPES_ROUTE))
                    {
                        return false;
                    }

                    Action scrollableActions = 
                        Action.SCROLL_RIGHT | 
                        Action.SCROLL_LEFT | 
                        Action.SCROLL_UP | 
                        Action.SCROLL_DOWN;
                    return (Actions & ~scrollableActions) != 0 || 
                        Flags != 0 || 
                        (Label != null && !string.IsNullOrWhiteSpace(Label)) || 
                        (Value != null && !string.IsNullOrWhiteSpace(Value)) || 
                        (Hint != null && !string.IsNullOrWhiteSpace(Hint));
                }
            }

            public void CollectRoutes(List<SemanticsObject> edges)
            {
                if (HasFlag(Flag.SCOPES_ROUTE))
                    edges.Add(this);

                if (childrenInTraversalOrder == null)
                    return;

                foreach (var child in childrenInTraversalOrder)
                    child.CollectRoutes(edges);
            }

            public string GetRouteName()
            {
                // Returns the first non-null and non-empty semantic label of a child
                // with an NamesRoute flag. Otherwise returns null.
                if (HasFlag(Flag.NAMES_ROUTE))
                {
                    if (Label != null && !string.IsNullOrWhiteSpace(Label))
                        return Label;
                }

                if (childrenInTraversalOrder != null)
                {
                    foreach (var child in childrenInTraversalOrder)
                    {
                        string newName = child.GetRouteName();
                        if (newName != null && !string.IsNullOrWhiteSpace(newName))
                            return newName;
                    }
                }

                return null;
            }

            public void UpdateRecursively(
                float[] ancestorTransform,
                List<SemanticsObject> visitedObjects,
                bool forceUpdate)
            {
                visitedObjects.Add(this);

                if (globalGeometryDirty)
                {
                    forceUpdate = true;
                }

                if (forceUpdate)
                {
                    if (globalTransform == null)
                    {
                        globalTransform = new float[16];
                    }

                    Matrix.MultiplyMM(globalTransform, 0, ancestorTransform, 0, transform, 0);

                    float[] sample = new float[4];
                    sample[2] = 0;
                    sample[3] = 1;

                    float[] point1 = new float[4];
                    float[] point2 = new float[4];
                    float[] point3 = new float[4];
                    float[] point4 = new float[4];

                    sample[0] = left;
                    sample[1] = top;
                    TransformPoint(point1, globalTransform, sample);

                    sample[0] = right;
                    sample[1] = top;
                    TransformPoint(point2, globalTransform, sample);

                    sample[0] = right;
                    sample[1] = bottom;
                    TransformPoint(point3, globalTransform, sample);

                    sample[0] = left;
                    sample[1] = bottom;
                    TransformPoint(point4, globalTransform, sample);

                    if (globalRect == null) globalRect = new Rect();

                    globalRect = new Rect(
                        (int)Math.Round(Min(point1[0], point2[0], point3[0], point4[0])),
                        (int)Math.Round(Min(point1[1], point2[1], point3[1], point4[1])),
                        (int)Math.Round(Max(point1[0], point2[0], point3[0], point4[0])),
                        (int)Math.Round(Max(point1[1], point2[1], point3[1], point4[1])));

                    globalGeometryDirty = false;
                }

                //assert globalTransform != null;
                //assert globalRect != null;

                if (childrenInTraversalOrder != null)
                {
                    foreach (var child in childrenInTraversalOrder)
                    {
                        child.UpdateRecursively(
                            globalTransform,
                            visitedObjects,
                            forceUpdate);
                    }
                }
            }

            private void TransformPoint(float[] result, float[] transform, float[] point)
            {
                Matrix.MultiplyMV(result, 0, transform, 0, point, 0);
                float w = result[3];
                result[0] /= w;
                result[1] /= w;
                result[2] /= w;
                result[3] = 0;
            }

            private float Min(float a, float b, float c, float d)
            {
                return Math.Min(a, Math.Min(b, Math.Min(c, d)));
            }

            private float Max(float a, float b, float c, float d)
            {
                return Math.Max(a, Math.Max(b, Math.Max(c, d)));
            }

            public string GetValueLabelHint()
            {
                string[] array = { Value, Label, Hint };

                var line = string.Join(", ", array);
                return string.IsNullOrWhiteSpace(line) ? null : line;
            }
        }
    }
}
