using Android.App;
using Android.OS;
using Android.Views;
using Android.Views.Accessibility;
using Flutter.Shell.Droid.Plugin.Common;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.Linq;
using FlutterBinding.Extensions;
using FlutterBinding.UI;
using SkiaSharp;
//using AccessibilityNodeInfo = Android.Support.V4.View.Accessibility.AccessibilityNodeInfoCompat;
using Math = System.Math;
using Matrix = Android.Opengl.Matrix;
using Rect = Android.Graphics.Rect;
using TextDirection = FlutterBinding.UI.TextDirection;

// ReSharper disable All

namespace Flutter.Shell.Droid.View
{
    public class AccessibilityBridge :
        AccessibilityNodeProvider,
        BasicMessageChannel<object>.IMessageHandler
    {
        private static readonly string TAG = "FlutterView";

        // Constants from higher API levels.
        // TODO(goderbauer): Get these from Android Support Library when
        // https://github.com/flutter/flutter/issues/11099 is resolved.
        private static readonly int ACTION_SHOW_ON_SCREEN = 16908342; // API level 23

        private static readonly float SCROLL_EXTENT_FOR_INFINITY = 100000.0f;
        private static readonly float SCROLL_POSITION_CAP_FOR_INFINITY = 70000.0f;
        private static readonly int ROOT_NODE_ID = 0;

        private readonly Dictionary<int, SemanticsObject> _objects;
        private readonly Dictionary<int, CustomAccessibilityAction> _customAccessibilityActions;
        private readonly FlutterView _owner;
        private bool _accessibilityEnabled = false;
        private SemanticsObject _a11YFocusedObject;
        private SemanticsObject _inputFocusedObject;
        private SemanticsObject _hoveredObject;
        private int _previousRouteId = ROOT_NODE_ID;
        private readonly List<int> _previousRoutes;
        private readonly Android.Views.View _decorView;
        private int _lastLeftFrameInset = 0;

        private readonly BasicMessageChannel<object> _flutterAccessibilityChannel;

        public AccessibilityBridge(FlutterView owner)
        {
            //assert owner != null;
            _owner                      = owner;
            _objects                    = new Dictionary<int, SemanticsObject>();
            _customAccessibilityActions = new Dictionary<int, CustomAccessibilityAction>();
            _previousRoutes             = new List<int>();
            _flutterAccessibilityChannel = new BasicMessageChannel<object>(
                owner,
                "flutter/accessibility",
                StandardMessageCodec.Instance);
            _decorView = ((Activity)owner.Context).Window.DecorView;
        }

        public void SetAccessibilityEnabled(bool accessibilityEnabled)
        {
            _accessibilityEnabled = accessibilityEnabled;
            _flutterAccessibilityChannel.SetMessageHandler(accessibilityEnabled ? this : null);
        }

        //@Override
        //@SuppressWarnings("deprecation")
        public override AccessibilityNodeInfo CreateAccessibilityNodeInfo(int virtualViewId)
        {
            if (virtualViewId == Android.Views.View.NoId)
            {
                AccessibilityNodeInfo aResult = AccessibilityNodeInfo.Obtain(_owner);
                _owner.OnInitializeAccessibilityNodeInfo(aResult);
                if (_objects.ContainsKey(ROOT_NODE_ID))
                {
                    aResult.AddChild(_owner, ROOT_NODE_ID);
                }

                return aResult;
            }

            SemanticsObject @object = _objects[virtualViewId];
            if (@object == null)
            {
                return null;
            }

            AccessibilityNodeInfo result = AccessibilityNodeInfo.Obtain(_owner, virtualViewId);
            // Work around for https://github.com/flutter/flutter/issues/2101
            if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBeanMr2)
            {
                result.ViewIdResourceName = "";
            }

            result.PackageName = _owner.Context.PackageName;
            result.ClassName   = "android.view.View";
            result.SetSource(_owner, virtualViewId);
            result.Focusable = @object.IsFocusable;
            if (_inputFocusedObject != null)
            {
                result.Focused = _inputFocusedObject.Id == virtualViewId;
            }

            if (_a11YFocusedObject != null)
            {
                result.AccessibilityFocused = (_a11YFocusedObject.Id == virtualViewId);
            }

            if (@object.HasFlag(SemanticsFlag.isTextField))
            {
                result.Password  = @object.HasFlag(SemanticsFlag.isObscured);
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
                        _a11YFocusedObject != null &&
                        _a11YFocusedObject.Id == virtualViewId)
                    {
                        result.LiveRegion = AccessibilityLiveRegion.Polite;
                    }
                }

                // Cursor movements
                int granularities = 0;
                if (@object.HasAction(SemanticsAction.MoveCursorForwardByCharacter))
                {
                    result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionNextAtMovementGranularity);
                    granularities |= (int)MovementGranularity.Character;
                }

                if (@object.HasAction(SemanticsAction.MoveCursorBackwardByCharacter))
                {
                    result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionPreviousAtMovementGranularity);
                    granularities |= (int)MovementGranularity.Character;
                }

                if (@object.HasAction(SemanticsAction.MoveCursorForwardByWord))
                {
                    result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionNextAtMovementGranularity);
                    granularities |= (int)MovementGranularity.Word;
                }

                if (@object.HasAction(SemanticsAction.MoveCursorBackwardByWord))
                {
                    result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionPreviousAtMovementGranularity);
                    granularities |= (int)MovementGranularity.Word;
                }

                result.MovementGranularities = (MovementGranularity)granularities;
            }

            if (@object.HasAction(SemanticsAction.SetSelection))
            {
                result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionSetSelection);
            }

            if (@object.HasAction(SemanticsAction.Copy))
            {
                result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionCopy);
            }

            if (@object.HasAction(SemanticsAction.Cut))
            {
                result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionCut);
            }

            if (@object.HasAction(SemanticsAction.Paste))
            {
                result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionPaste);
            }

            if (@object.HasFlag(SemanticsFlag.IsButton))
            {
                result.ClassName = "android.widget.Button";
            }

            if (@object.HasFlag(SemanticsFlag.isImage))
            {
                result.ClassName = "android.widget.ImageView";
                // TODO(jonahwilliams): Figure out a way conform to the expected id from TalkBack's
                // CustomLabelManager. talkback/src/main/java/labeling/CustomLabelManager.java#L525
            }

            if (Build.VERSION.SdkInt > BuildVersionCodes.JellyBeanMr2 && @object.HasAction(SemanticsAction.Dismiss))
            {
                result.Dismissable = true;
                result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionDismiss);
            }

            if (@object.parent != null)
            {
                //assert @object.Id > ROOT_NODE_ID;
                result.SetParent(_owner, @object.parent.Id);
            }
            else
            {
                //assert @object.Id == ROOT_NODE_ID;
                result.SetParent(_owner);
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
            result.Enabled       = !@object.HasFlag(SemanticsFlag.hasEnabledState) || @object.HasFlag(SemanticsFlag.isEnabled);

            if (@object.HasAction(SemanticsAction.Tap))
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop && @object.onTapOverride != null)
                {
                    result.ActionList.Add(
                        new AccessibilityNodeInfo.AccessibilityAction(
                            (int)AccessibilityNodeInfo.AccessibilityAction.ActionClick,
                            new Java.Lang.String(@object.onTapOverride.Hint)));
                    result.Clickable = true;
                }
                else
                {
                    result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionClick);
                    result.Clickable = true;
                }
            }

            if (@object.HasAction(SemanticsAction.LongPress))
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop && @object.onLongPressOverride != null)
                {
                    result.ActionList.Add(
                        new AccessibilityNodeInfo.AccessibilityAction(
                            (int)AccessibilityNodeInfo.AccessibilityAction.ActionLongClick,
                            new Java.Lang.String(@object.onLongPressOverride.Hint)));
                    result.LongClickable = true;
                }
                else
                {
                    result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionLongClick);
                    result.LongClickable = true;
                }
            }

            if (@object.HasAction(SemanticsAction.ScrollLeft) || @object.HasAction(SemanticsAction.ScrollUp)
                || @object.HasAction(SemanticsAction.ScrollRight) || @object.HasAction(SemanticsAction.ScrollDown))
            {
                result.Scrollable = true;
                // This tells Android's a11y to send scroll events when reaching the end of
                // the visible viewport of a scrollable, unless the node itself does not
                // allow implicit scrolling - then we leave the className as view.View.
                if (@object.HasFlag(SemanticsFlag.hasImplicitScrolling))
                {
                    if (@object.HasAction(SemanticsAction.ScrollLeft) || @object.HasAction(SemanticsAction.ScrollRight))
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
                if (@object.HasAction(SemanticsAction.ScrollLeft) || @object.HasAction(SemanticsAction.ScrollUp))
                {
                    result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionScrollForward);
                }

                if (@object.HasAction(SemanticsAction.ScrollRight) || @object.HasAction(SemanticsAction.ScrollDown))
                {
                    result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionScrollBackward);
                }
            }

            if (@object.HasAction(SemanticsAction.Increase) || @object.HasAction(SemanticsAction.Decrease))
            {
                // TODO(jonahwilliams): support AccessibilityAction.ACTION_SET_PROGRESS once SDK is
                // updated.
                result.ClassName = "android.widget.SeekBar";
                if (@object.HasAction(SemanticsAction.Increase))
                {
                    result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionScrollForward);
                }

                if (@object.HasAction(SemanticsAction.Decrease))
                {
                    result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionScrollBackward);
                }
            }

            if (@object.HasFlag(SemanticsFlag.isLiveRegion) && Build.VERSION.SdkInt > BuildVersionCodes.JellyBeanMr2)
            {
                result.LiveRegion = AccessibilityLiveRegion.Polite;
            }

            bool hasCheckedState = @object.HasFlag(SemanticsFlag.hasCheckedState);
            bool hasToggledState = @object.HasFlag(SemanticsFlag.hasToggledState);
            //assert !(hasCheckedState && hasToggledState);
            result.Checkable = (hasCheckedState || hasToggledState);
            if (hasCheckedState)
            {
                result.Checked            = @object.HasFlag(SemanticsFlag.isChecked);
                result.ContentDescription = @object.GetValueLabelHint();
                if (@object.HasFlag(SemanticsFlag.isInMutuallyExclusiveGroup))
                    result.ClassName = "android.widget.RadioButton";
                else
                    result.ClassName = "android.widget.CheckBox";
            }
            else if (hasToggledState)
            {
                result.Checked            = @object.HasFlag(SemanticsFlag.isToggled);
                result.ClassName          = "android.widget.Switch";
                result.ContentDescription = @object.GetValueLabelHint();
            }
            else
            {
                // Setting the text directly instead of the content description
                // will replace the "checked" or "not-checked" label.
                result.Text = @object.GetValueLabelHint();
            }

            result.Selected = @object.HasFlag(SemanticsFlag.isSelected);

            // Accessibility Focus
            if (_a11YFocusedObject != null && _a11YFocusedObject.Id == virtualViewId)
            {
                result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionClearFocus);
            }
            else
            {
                result.ActionList.Add(AccessibilityNodeInfo.AccessibilityAction.ActionAccessibilityFocus);
            }

            // Actions on the local context menu
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                if (@object.customAccessibilityActions != null)
                {
                    foreach (CustomAccessibilityAction action in @object.customAccessibilityActions)
                    {
                        result.ActionList.Add(new AccessibilityNodeInfo.AccessibilityAction(action.ResourceId, action.Label));
                    }
                }
            }

            if (@object.childrenInTraversalOrder != null)
            {
                foreach (SemanticsObject child in @object.childrenInTraversalOrder)
                {
                    if (!child.HasFlag(SemanticsFlag.isHidden))
                    {
                        result.AddChild(_owner, child.Id);
                    }
                }
            }

            return result;
        }

        /// <inheritdoc />
        public override bool PerformAction(int virtualViewId, Android.Views.Accessibility.Action action, Bundle arguments)
        {
            SemanticsObject @object = _objects[virtualViewId];
            if (@object == null)
            {
                return false;
            }

            if (action == Android.Views.Accessibility.Action.Click)
            {
                // Note: TalkBack prior to Oreo doesn't use this handler and instead simulates a
                //     click event at the center of the SemanticsNode. Other a11y services might go
                //     through this handler though.
                _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.Tap);
                return true;
            }

            if (action == Android.Views.Accessibility.Action.LongClick)
            {
                // Note: TalkBack doesn't use this handler and instead simulates a long click event
                //     at the center of the SemanticsNode. Other a11y services might go through this
                //     handler though.
                _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.LongPress);
                return true;
            }

            if (action == Android.Views.Accessibility.Action.ScrollForward)
            {
                if (@object.HasAction(SemanticsAction.ScrollUp))
                {
                    _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.ScrollUp);
                }
                else if (@object.HasAction(SemanticsAction.ScrollLeft))
                {
                    // TODO(ianh): bidi support using textDirection
                    _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.ScrollLeft);
                }
                else if (@object.HasAction(SemanticsAction.Increase))
                {
                    @object.Value = @object.IncreasedValue;
                    // Event causes Android to read out the updated value.
                    SendAccessibilityEvent(virtualViewId, EventTypes.ViewSelected);
                    _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.Increase);
                }
                else
                {
                    return false;
                }

                return true;
            }

            if (action == Android.Views.Accessibility.Action.ScrollBackward)
            {
                if (@object.HasAction(SemanticsAction.ScrollDown))
                {
                    _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.ScrollDown);
                }
                else if (@object.HasAction(SemanticsAction.ScrollRight))
                {
                    // TODO(ianh): bidi support using textDirection
                    _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.ScrollRight);
                }
                else if (@object.HasAction(SemanticsAction.Decrease))
                {
                    @object.Value = @object.DecreasedValue;
                    // Event causes Android to read out the updated value.
                    SendAccessibilityEvent(virtualViewId, EventTypes.ViewSelected);
                    _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.Decrease);
                }
                else
                {
                    return false;
                }

                return true;
            }

            if (action == Android.Views.Accessibility.Action.PreviousAtMovementGranularity)
            {
                return PerformCursorMoveAction(@object, virtualViewId, arguments, false);
            }

            if (action == Android.Views.Accessibility.Action.NextAtMovementGranularity)
            {
                return PerformCursorMoveAction(@object, virtualViewId, arguments, true);
            }

            if (action == Android.Views.Accessibility.Action.ClearAccessibilityFocus)
            {
                _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.DidLoseAccessibilityFocus);
                SendAccessibilityEvent(
                    virtualViewId,
                    EventTypes.ViewAccessibilityFocusCleared);
                _a11YFocusedObject = null;
                return true;
            }

            if (action == Android.Views.Accessibility.Action.AccessibilityFocus)
            {
                _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.DidGainAccessibilityFocus);
                SendAccessibilityEvent(
                    virtualViewId,
                    EventTypes.ViewAccessibilityFocused);
                if (_a11YFocusedObject == null)
                {
                    // When Android focuses a node, it doesn't invalidate the view.
                    // (It does when it sends ACTION_CLEAR_ACCESSIBILITY_FOCUS, so
                    // we only have to worry about this when the focused node is null.)
                    _owner.Invalidate();
                }

                _a11YFocusedObject = @object;

                if (@object.HasAction(SemanticsAction.Increase) || @object.HasAction(SemanticsAction.Decrease))
                {
                    // SeekBars only announce themselves after this event.
                    SendAccessibilityEvent(virtualViewId, EventTypes.ViewSelected);
                }

                return true;
            }

            // TODO: Moved to default: clause
            //case AccessibilityBridge.ACTION_SHOW_ON_SCREEN:
            //    {
            //        mOwner.DispatchSemanticsAction(virtualViewId, Action.SHOW_ON_SCREEN);
            //        return true;
            //    }
            if (action == Android.Views.Accessibility.Action.SetSelection)
            {
                Dictionary<string, int> selection = new Dictionary<string, int>();
                bool hasSelection = arguments != null
                    && arguments.ContainsKey(AccessibilityNodeInfo.ActionArgumentSelectionStartInt)
                    && arguments.ContainsKey(AccessibilityNodeInfo.ActionArgumentSelectionEndInt);
                if (hasSelection)
                {
                    selection["base"]   = arguments.GetInt(AccessibilityNodeInfo.ActionArgumentSelectionStartInt);
                    selection["extent"] = arguments.GetInt(AccessibilityNodeInfo.ActionArgumentSelectionEndInt);
                }
                else
                {
                    // Clear the selection
                    selection["base"]   = @object.TextSelectionExtent;
                    selection["extent"] = @object.TextSelectionExtent;
                }

                _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.SetSelection, selection);
                return true;
            }

            if (action == Android.Views.Accessibility.Action.Copy)
            {
                _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.Copy);
                return true;
            }

            if (action == Android.Views.Accessibility.Action.Cut)
            {
                _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.Cut);
                return true;
            }

            if (action == Android.Views.Accessibility.Action.Paste)
            {
                _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.Paste);
                return true;
            }

            if (action == Android.Views.Accessibility.Action.Dismiss)
            {
                _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.Dismiss);
                return true;
            }

            if ((int)action == ACTION_SHOW_ON_SCREEN)
            {
                _owner.DispatchSemanticsAction(virtualViewId, SemanticsAction.ShowOnScreen);
                return true;
            }

            // might be a custom accessibility action.
            int flutterId = (int)action - firstResourceId;
            CustomAccessibilityAction contextAction = _customAccessibilityActions[flutterId];
            if (contextAction != null)
            {
                _owner.DispatchSemanticsAction(
                    virtualViewId,
                    SemanticsAction.CustomAction,
                    contextAction.Id);
                return true;
            }

            return false;
        }

        private bool PerformCursorMoveAction(SemanticsObject @object, int virtualViewId, Bundle arguments, bool forward)
        {
            MovementGranularity granularity = (MovementGranularity)arguments.GetInt(AccessibilityNodeInfo.ActionArgumentMovementGranularityInt);
            bool extendSelection = arguments.GetBoolean(AccessibilityNodeInfo.ActionArgumentExtendSelectionBoolean);
            switch (granularity)
            {
            case MovementGranularity.Character:
            {
                if (forward && @object.HasAction(SemanticsAction.MoveCursorForwardByCharacter))
                {
                    _owner.DispatchSemanticsAction(
                        virtualViewId,
                        SemanticsAction.MoveCursorForwardByCharacter,
                        extendSelection);
                    return true;
                }

                if (!forward && @object.HasAction(SemanticsAction.MoveCursorBackwardByCharacter))
                {
                    _owner.DispatchSemanticsAction(
                        virtualViewId,
                        SemanticsAction.MoveCursorBackwardByCharacter,
                        extendSelection);
                    return true;
                }

                break;
            }
            case MovementGranularity.Word:
                if (forward && @object.HasAction(SemanticsAction.MoveCursorForwardByWord))
                {
                    _owner.DispatchSemanticsAction(
                        virtualViewId,
                        SemanticsAction.MoveCursorForwardByWord,
                        extendSelection);
                    return true;
                }

                if (!forward && @object.HasAction(SemanticsAction.MoveCursorBackwardByWord))
                {
                    _owner.DispatchSemanticsAction(
                        virtualViewId,
                        SemanticsAction.MoveCursorBackwardByWord,
                        extendSelection);
                    return true;
                }

                break;
            }

            return false;
        }

        // TODO(ianh): implement findAccessibilityNodeInfosByText()

        //@Override
        /// <inheritdoc />
        public override AccessibilityNodeInfo FindFocus(NodeFocus focus)
        {
            if (focus == NodeFocus.Input)
            {
                if (_inputFocusedObject != null)
                    return CreateAccessibilityNodeInfo(_inputFocusedObject.Id);
            }

            if (focus == NodeFocus.Input || focus == NodeFocus.Accessibility)
            {
                if (_a11YFocusedObject != null)
                    return CreateAccessibilityNodeInfo(_a11YFocusedObject.Id);
            }

            return null;
        }

        private SemanticsObject GetRootObject()
        {
            //assert mObjects.containsKey(0);
            return _objects[0];
        }

        private SemanticsObject GetOrCreateObject(int id)
        {
            SemanticsObject @object = _objects[id];
            if (@object == null)
            {
                @object = new SemanticsObject(this)
                {
                    Id = id
                };
                _objects[id] = @object;
            }

            return @object;
        }

        private CustomAccessibilityAction GetOrCreateAction(int id)
        {
            CustomAccessibilityAction action = _customAccessibilityActions[id];
            if (action == null)
            {
                action = new CustomAccessibilityAction
                {
                    Id         = id,
                    ResourceId = id + firstResourceId
                };
                _customAccessibilityActions[id] = action;
            }

            return action;
        }

        public void HandleTouchExplorationExit()
        {
            if (_hoveredObject != null)
            {
                SendAccessibilityEvent(_hoveredObject.Id, EventTypes.ViewHoverExit);
                _hoveredObject = null;
            }
        }

        public void HandleTouchExploration(float x, float y)
        {
            if (_objects.Count == 0)
                return;

            SemanticsObject newObject = GetRootObject().HitTest(new float[] {x, y, 0, 1});
            if (newObject != _hoveredObject)
            {
                // sending ENTER before EXIT is how Android wants it
                if (newObject != null)
                {
                    SendAccessibilityEvent(newObject.Id, EventTypes.ViewHoverEnter);
                }

                if (_hoveredObject != null)
                {
                    SendAccessibilityEvent(_hoveredObject.Id, EventTypes.ViewHoverExit);
                }

                _hoveredObject = newObject;
            }
        }

        // TODO: ByteBuffer->object
        public void UpdateCustomAccessibilityActions(object buffer, string[] strings)
        {
            List<CustomAccessibilityAction> list = (List<CustomAccessibilityAction>)buffer;
            foreach (CustomAccessibilityAction action in list)
            {
                CustomAccessibilityAction origAction = GetOrCreateAction(action.Id);
                origAction.OverrideId = action.OverrideId;
                origAction.Label      = action.Label;
                origAction.Hint       = action.Hint;
            }
        }

        // TODO: ByteBuffer->object
        public void UpdateSemantics(SemanticsNodeUpdates update, CustomAccessibilityActionUpdates actions)
        {
            List<SemanticsObject> updated = new List<SemanticsObject>();
            //List<SemanticsParameter> list = (List<SemanticsParameter>)buffer;


            foreach (var pair in update)
            {
                var id = pair.Key;
                var semanticNode = pair.Value;

                SemanticsObject @object = GetOrCreateObject(id);
                @object.UpdateWith(semanticNode, actions);
                if (@object.HasFlag(SemanticsFlag.isHidden))
                    continue;

                if (@object.HasFlag(SemanticsFlag.isFocused))
                    _inputFocusedObject = @object;

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
                    _decorView.GetWindowVisibleDisplayFrame(visibleFrame);
                    if (!_lastLeftFrameInset.Equals(visibleFrame.Left))
                    {
                        rootObject.globalGeometryDirty   = true;
                        rootObject.inverseTransformDirty = true;
                    }

                    _lastLeftFrameInset = visibleFrame.Left;
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
                if (!_previousRoutes.Contains(semanticsObject.Id))
                {
                    lastAdded = semanticsObject;
                }
            }

            if (lastAdded == null && newRoutes.Count > 0)
            {
                lastAdded = newRoutes[newRoutes.Count - 1];
            }

            if (lastAdded != null && lastAdded.Id != _previousRouteId)
            {
                _previousRouteId = lastAdded.Id;
                CreateWindowChangeEvent(lastAdded);
            }

            _previousRoutes.Clear();
            foreach (SemanticsObject semanticsObject in newRoutes)
            {
                _previousRoutes.Add(semanticsObject.Id);
            }

            foreach (KeyValuePair<int, SemanticsObject> entry in _objects.ToList())
            {
                SemanticsObject @object = entry.Value;
                if (!visitedObjects.Contains(@object))
                {
                    WillRemoveSemanticsObject(@object);
                    _objects.Remove(entry.Key); //it.remove();
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
                        max      -= @object.ScrollExtentMin;
                        position -= @object.ScrollExtentMin;
                    }

                    if (@object.HadAction(SemanticsAction.ScrollUp) || @object.HadAction(SemanticsAction.ScrollDown))
                    {
                        @event.ScrollY    = (int)position;
                        @event.MaxScrollY = (int)max;
                    }
                    else if (@object.HadAction(SemanticsAction.ScrollLeft)
                        || @object.HadAction(SemanticsAction.ScrollRight))
                    {
                        @event.ScrollX    = (int)position;
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
                            if (!child.HasFlag(SemanticsFlag.isHidden))
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

                if (@object.HasFlag(SemanticsFlag.isLiveRegion))
                {
                    string label = @object.Label == null ? "" : @object.Label;
                    string previousLabel = @object.Previous?.Label ?? @object.Label;
                    if (!label.Equals(previousLabel) || !@object.HadFlag(SemanticsFlag.isLiveRegion))
                    {
                        SendAccessibilityEvent(@object.Id, EventTypes.WindowContentChanged);
                    }
                }
                else if (@object.HasFlag(SemanticsFlag.isTextField) && @object.DidChangeLabel()
                    && _inputFocusedObject != null && _inputFocusedObject.Id == @object.Id)
                {
                    // Text fields should announce when their label changes while focused. We use a live
                    // region tag to do so, and this event triggers that update.
                    SendAccessibilityEvent(@object.Id, EventTypes.WindowContentChanged);
                }

                if (_a11YFocusedObject != null && _a11YFocusedObject.Id == @object.Id
                    && !@object.HadFlag(SemanticsFlag.isSelected) && @object.HasFlag(SemanticsFlag.isSelected))
                {
                    AccessibilityEvent @event =
                        ObtainAccessibilityEvent(@object.Id, EventTypes.ViewSelected);
                    @event.Text.Add(new Java.Lang.String(@object.Label));
                    SendAccessibilityEvent(@event);
                }

                if (_inputFocusedObject != null && _inputFocusedObject.Id == @object.Id
                    && @object.HadFlag(SemanticsFlag.isTextField) && @object.HasFlag(SemanticsFlag.isTextField)
                    // If we have a TextField that has InputFocus, we should avoid announcing it if something
                    // else we track has a11y focus. This needs to still work when, e.g., IME has a11y focus
                    // or the "PASTE" popup is used though.
                    // See more discussion at https://github.com/flutter/flutter/issues/23180
                    && (_a11YFocusedObject == null || (_a11YFocusedObject.Id == _inputFocusedObject.Id)))
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
                            @object.Id,
                            EventTypes.ViewTextSelectionChanged);
                        selectionEvent.Text.Add(new Java.Lang.String(newValue));
                        selectionEvent.FromIndex = @object.TextSelectionBase;
                        selectionEvent.ToIndex   = @object.TextSelectionExtent;
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
            e.AddedCount   = newIndex - firstDifference + 1;

            return e;
        }

        private AccessibilityEvent ObtainAccessibilityEvent(int virtualViewId, EventTypes eventType)
        {
            //assert virtualViewId != ROOT_NODE_ID;
            AccessibilityEvent @event = AccessibilityEvent.Obtain(eventType);
            @event.PackageName = _owner.Context.PackageName;
            @event.SetSource(_owner, virtualViewId);
            return @event;
        }

        private void SendAccessibilityEvent(int virtualViewId, EventTypes eventType)
        {
            if (!_accessibilityEnabled)
            {
                return;
            }

            if (virtualViewId == ROOT_NODE_ID)
            {
                _owner.SendAccessibilityEvent(eventType);
            }
            else
            {
                SendAccessibilityEvent(ObtainAccessibilityEvent(virtualViewId, eventType));
            }
        }

        private void SendAccessibilityEvent(AccessibilityEvent @event)
        {
            if (!_accessibilityEnabled)
            {
                return;
            }

            _owner.Parent.RequestSendAccessibilityEvent(_owner, @event);
        }

        // Message Handler for [mFlutterAccessibilityChannel].
        public void OnMessage(object message, BasicMessageChannel<object>.IReply reply)
        {
            //@SuppressWarnings("unchecked")
            Dictionary<string, object> annotatedEvent = (Dictionary<string, object>)message;
            string type = (string)annotatedEvent["type"];
            //@SuppressWarnings("unchecked")
            Dictionary<string, object> data = (Dictionary<string, object>)annotatedEvent["data"];

            switch (type)
            {
            case "announce":
                _owner.AnnounceForAccessibility((string)data["message"]);
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
                e.Text.Add(new Java.Lang.String((string)data["message"]));
                SendAccessibilityEvent(e);
                break;
            }
            }
        }

        private void CreateWindowChangeEvent(SemanticsObject route)
        {
            AccessibilityEvent e = ObtainAccessibilityEvent(route.Id, EventTypes.WindowStateChanged);
            Java.Lang.String routeName = new Java.Lang.String(route.GetRouteName());
            e.Text.Add(routeName);
            SendAccessibilityEvent(e);
        }

        private void WillRemoveSemanticsObject(SemanticsObject @object)
        {
            //assert mObjects.containsKey(@object.Id);
            //assert mObjects.get(@object.Id) == object;
            @object.parent = null;
            if (_a11YFocusedObject == @object)
            {
                SendAccessibilityEvent(
                    _a11YFocusedObject.Id,
                    EventTypes.ViewAccessibilityFocusCleared);
                _a11YFocusedObject = null;
            }

            if (_inputFocusedObject == @object)
            {
                _inputFocusedObject = null;
            }

            if (_hoveredObject == @object)
            {
                _hoveredObject = null;
            }
        }

        public void Reset()
        {
            _objects.Clear();
            if (_a11YFocusedObject != null)
                SendAccessibilityEvent(
                    _a11YFocusedObject.Id,
                    EventTypes.ViewAccessibilityFocusCleared);
            _a11YFocusedObject = null;
            _hoveredObject     = null;
            SendAccessibilityEvent(0, EventTypes.WindowContentChanged);
        }

        /*
        public enum TextDirection
        {
            UNKNOWN,
            LTR = 2,
            RTL = 1
        }
        */

        private class CustomAccessibilityAction
        {
            public CustomAccessibilityAction() { }

            /// Resource id is the id of the custom action plus a minimum value so that the identifier
            /// does not collide with existing Android accessibility actions.
            public int ResourceId = -1;

            public int Id = -1;
            public SemanticsAction OverrideId = SemanticsAction.Unknown;

            /// The label is the user presented value which is displayed in the local context menu.
            public string Label;

            /// The hint is the text used in overriden standard actions.
            public string Hint;

            public bool IsStandardAction => OverrideId != SemanticsAction.Unknown;
        }

        /// Value is derived from ACTION_TYPE_MASK in AccessibilityNodeInfo.java
        private static readonly int firstResourceId = 267386881;

        public class SemanticsParameter
        {
            public int Id;
            public SemanticsFlag Flags;
            public SemanticsAction Actions;
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
            public SemanticsObject(AccessibilityBridge parent)
            {
                _parent = parent;
            }

            public int Id = -1;
            public SemanticsFlag Flags;
            public SemanticsAction Actions;
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

            private AccessibilityBridge _parent;
            public SemanticsParameter Previous = new SemanticsParameter();

            private float left;
            private float top;
            private float right;
            private float bottom;
            private SKMatrix44 transform;

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

            public bool HasAction(SemanticsAction accessibilityBridgeAction)
            {
                return Actions.HasFlag(accessibilityBridgeAction);
            }

            public bool HadAction(SemanticsAction accessibilityBridgeAction)
            {
                return Previous.Actions.HasFlag(accessibilityBridgeAction);
            }

            public bool HasFlag(SemanticsFlag flag)
            {
                return Flags.HasFlag(flag);
            }

            public bool HadFlag(SemanticsFlag flag)
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
                    + "  +-- transform=" + transform.ToString() + "\n");

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
            public void UpdateWith(SemanticsNode parameter, CustomAccessibilityActionUpdates actions)
            {
                HadPreviousConfig = true;
                Previous = new SemanticsParameter
                {
                    Value               = Value,
                    Label               = Label,
                    Flags               = Flags,
                    Actions             = Actions,
                    TextSelectionBase   = TextSelectionBase,
                    TextSelectionExtent = TextSelectionExtent,
                    ScrollPosition      = ScrollPosition,
                    ScrollExtentMax     = ScrollExtentMax,
                    ScrollExtentMin     = ScrollExtentMin
                };

                Flags               = parameter.Flags;
                Actions             = parameter.Actions;
                TextSelectionBase   = parameter.TextSelectionBase;
                TextSelectionExtent = parameter.TextSelectionExtent;
                ScrollChildren      = parameter.ScrollChildren;
                ScrollIndex         = parameter.ScrollIndex;
                ScrollPosition      = parameter.ScrollPosition;
                ScrollExtentMax     = parameter.ScrollExtentMax;
                ScrollExtentMin     = parameter.ScrollExtentMin;

                Label          = parameter.Label;
                Value          = parameter.Value;
                IncreasedValue = parameter.IncreasedValue;
                DecreasedValue = parameter.DecreasedValue;
                Hint           = parameter.Hint;
                TextDirection  = parameter.TextDirection;

                left      = parameter.Rect.Left;
                top       = parameter.Rect.Top;
                right     = parameter.Rect.Right;
                bottom    = parameter.Rect.Bottom;
                transform = parameter.Transform;

                inverseTransformDirty = true;
                globalGeometryDirty   = true;

                childrenInTraversalOrder = new FlutterSDK.List<SemanticsObject>();
                childrenInHitTestOrder   = new FlutterSDK.List<SemanticsObject>();

                foreach (int id in parameter.ChildrenInTraversalOrder)
                {
                    SemanticsObject child = _parent.GetOrCreateObject(id);
                    child.parent = this;
                    childrenInTraversalOrder.Add(child);
                }

                foreach (int id in parameter.ChildrenInHitTestOrder)
                {
                    SemanticsObject child = _parent.GetOrCreateObject(id);
                    child.parent = this;
                    childrenInHitTestOrder.Add(child);
                }

                customAccessibilityActions = new FlutterSDK.List<CustomAccessibilityAction>();
                foreach (int id in parameter.CustomAccessibilityActions)
                {
                    CustomAccessibilityAction action = _parent.GetOrCreateAction(id);
                    if (action.OverrideId == SemanticsAction.Tap)
                    {
                        onTapOverride = action;
                    }
                    else if (action.OverrideId == SemanticsAction.LongPress)
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

                if (!Matrix.InvertM(inverseTransform, 0, transform.ToColumnMajor(), 0))
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
                        if (child.HasFlag(SemanticsFlag.isHidden))
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
                    if (HasFlag(SemanticsFlag.scopesRoute))
                    {
                        return false;
                    }

                    SemanticsAction scrollableActions =
                        SemanticsAction.ScrollRight |
                        SemanticsAction.ScrollLeft |
                        SemanticsAction.ScrollUp |
                        SemanticsAction.ScrollDown;
                    return (Actions & ~scrollableActions) != 0 ||
                        Flags != 0 ||
                        (Label != null && !string.IsNullOrWhiteSpace(Label)) ||
                        (Value != null && !string.IsNullOrWhiteSpace(Value)) ||
                        (Hint != null && !string.IsNullOrWhiteSpace(Hint));
                }
            }

            public void CollectRoutes(List<SemanticsObject> edges)
            {
                if (HasFlag(SemanticsFlag.scopesRoute))
                    edges.Add(this);

                if (childrenInTraversalOrder == null)
                    return;

                foreach (SemanticsObject child in childrenInTraversalOrder)
                    child.CollectRoutes(edges);
            }

            public string GetRouteName()
            {
                // Returns the first non-null and non-empty semantic label of a child
                // with an NamesRoute flag. Otherwise returns null.
                if (HasFlag(SemanticsFlag.namesRoute))
                {
                    if (Label != null && !string.IsNullOrWhiteSpace(Label))
                        return Label;
                }

                if (childrenInTraversalOrder != null)
                {
                    foreach (SemanticsObject child in childrenInTraversalOrder)
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
                    Matrix.MultiplyMM(globalTransform, 0, ancestorTransform, 0, transform.ToColumnMajor(), 0);

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
                    foreach (SemanticsObject child in childrenInTraversalOrder)
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
                result[3] =  0;
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
                string[] array = {Value, Label, Hint};

                string line = string.Join(", ", array);
                return string.IsNullOrWhiteSpace(line) ? null : line;
            }
        }
    }
}
