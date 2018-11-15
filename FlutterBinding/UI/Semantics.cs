using System;
using System.Collections.Generic;
using FlutterBinding.Mapping;
using SkiaSharp;

namespace FlutterBinding.UI
{
    /// The possible actions that can be conveyed from the operating system
    /// accessibility APIs to a semantics node.
    [Flags]
    public enum SemanticsAction
    {
        /// The equivalent of a user briefly tapping the screen with the finger
        /// without moving it.
        tap = 1 << 0,

        /// The equivalent of a user pressing and holding the screen with the finger
        /// for a few seconds without moving it.
        longPress = 1 << 1,

        /// The equivalent of a user moving their finger across the screen from right
        /// to left.
        ///
        /// This action should be recognized by controls that are horizontally
        /// scrollable.
        scrollLeft = 1 << 2,

        /// The equivalent of a user moving their finger across the screen from left
        /// to right.
        ///
        /// This action should be recognized by controls that are horizontally
        /// scrollable.
        scrollRight = 1 << 3,

        /// The equivalent of a user moving their finger across the screen from
        /// bottom to top.
        ///
        /// This action should be recognized by controls that are vertically
        /// scrollable.
        scrollUp = 1 << 4,

        /// The equivalent of a user moving their finger across the screen from top
        /// to bottom.
        ///
        /// This action should be recognized by controls that are vertically
        /// scrollable.
        scrollDown = 1 << 5,

        /// A request to increase the value represented by the semantics node.
        ///
        /// For example, this action might be recognized by a slider control.
        increase = 1 << 6,

        /// A request to decrease the value represented by the semantics node.
        ///
        /// For example, this action might be recognized by a slider control.
        decrease = 1 << 7,

        /// A request to fully show the semantics node on screen.
        ///
        /// For example, this action might be send to a node in a scrollable list that
        /// is partially off screen to bring it on screen.
        showOnScreen = 1 << 8,

        /// Move the cursor forward by one character.
        ///
        /// This is for example used by the cursor control in text fields.
        ///
        /// The action includes a boolean argument, which indicates whether the cursor
        /// movement should extend (or start) a selection.
        moveCursorForwardByCharacter = 1 << 9,

        /// Move the cursor backward by one character.
        ///
        /// This is for example used by the cursor control in text fields.
        ///
        /// The action includes a boolean argument, which indicates whether the cursor
        /// movement should extend (or start) a selection.
        moveCursorBackwardByCharacter = 1 << 10,

        /// Set the text selection to the given range.
        ///
        /// The provided argument is a Map<String, int> which includes the keys `base`
        /// and `extent` indicating where the selection within the `value` of the
        /// semantics node should start and where it should end. Values for both
        /// keys can range from 0 to length of `value` (inclusive).
        ///
        /// Setting `base` and `extent` to the same value will move the cursor to
        /// that position (without selecting anything).
        setSelection = 1 << 11,

        /// Copy the current selection to the clipboard.
        copy = 1 << 12,

        /// Cut the current selection and place it in the clipboard.
        cut = 1 << 13,

        /// Paste the current content of the clipboard.
        paste = 1 << 14,

        /// Indicates that the nodes has gained accessibility focus.
        ///
        /// This handler is invoked when the node annotated with this handler gains
        /// the accessibility focus. The accessibility focus is the
        /// green (on Android with TalkBack) or black (on iOS with VoiceOver)
        /// rectangle shown on screen to indicate what element an accessibility
        /// user is currently interacting with.
        ///
        /// The accessibility focus is different from the input focus. The input focus
        /// is usually held by the element that currently responds to keyboard inputs.
        /// Accessibility focus and input focus can be held by two different nodes!
        didGainAccessibilityFocus = 1 << 15,

        /// Indicates that the nodes has lost accessibility focus.
        ///
        /// This handler is invoked when the node annotated with this handler
        /// loses the accessibility focus. The accessibility focus is
        /// the green (on Android with TalkBack) or black (on iOS with VoiceOver)
        /// rectangle shown on screen to indicate what element an accessibility
        /// user is currently interacting with.
        ///
        /// The accessibility focus is different from the input focus. The input focus
        /// is usually held by the element that currently responds to keyboard inputs.
        /// Accessibility focus and input focus can be held by two different nodes!
        didLoseAccessibilityFocus = 1 << 16,

        /// Indicates that the user has invoked a custom accessibility action.
        ///
        /// This handler is added automatically whenever a custom accessibility
        /// action is added to a semantics node.
        customAction = 1 << 17,

        /// A request that the node should be dismissed.
        ///
        /// A [Snackbar], for example, may have a dismiss action to indicate to the
        /// user that it can be removed after it is no longer relevant. On Android,
        /// (with TalkBack) special hint text is spoken when focusing the node and
        /// a custom action is availible in the local context menu. On iOS,
        /// (with VoiceOver) users can perform a standard gesture to dismiss it.
        dismiss = 1 << 18,

        /// Move the cursor forward by one word.
        ///
        /// This is for example used by the cursor control in text fields.
        ///
        /// The action includes a boolean argument, which indicates whether the cursor
        /// movement should extend (or start) a selection.
        moveCursorForwardByWord = 1 << 19,

        /// Move the cursor backward by one word.
        ///
        /// This is for example used by the cursor control in text fields.
        ///
        /// The action includes a boolean argument, which indicates whether the cursor
        /// movement should extend (or start) a selection.
        moveCursorBackwardByWord = 1 << 20,
    }

    /// A Boolean value that can be associated with a semantics node.
    [Flags]
    public enum SemanticsFlag
    {
        /// The semantics node has the quality of either being "checked" or "unchecked".
        ///
        /// This flag is mutually exclusive with [hasToggledState].
        ///
        /// For example, a checkbox or a radio button widget has checked state.
        ///
        /// See also:
        ///
        ///   * [SemanticsFlag.isChecked], which controls whether the node is "checked" or "unchecked".
        hasCheckedState = 1 << 0,

        /// Whether a semantics node that [hasCheckedState] is checked.
        ///
        /// If true, the semantics node is "checked". If false, the semantics node is
        /// "unchecked".
        ///
        /// For example, if a checkbox has a visible checkmark, [isChecked] is true.
        ///
        /// See also:
        ///
        ///   * [SemanticsFlag.hasCheckedState], which enables a checked state.
        isChecked = 1 << 1,


        /// Whether a semantics node is selected.
        ///
        /// If true, the semantics node is "selected". If false, the semantics node is
        /// "unselected".
        ///
        /// For example, the active tab in a tab bar has [isSelected] set to true.
        isSelected = 1 << 2,

        /// Whether the semantic node represents a button.
        ///
        /// Platforms has special handling for buttons, for example Android's TalkBack
        /// and iOS's VoiceOver provides an additional hint when the focused object is
        /// a button.
        isButton = 1 << 3,

        /// Whether the semantic node represents a text field.
        ///
        /// Text fields are announced as such and allow text input via accessibility
        /// affordances.
        isTextField = 1 << 4,

        /// Whether the semantic node currently holds the user's focus.
        ///
        /// The focused element is usually the current receiver of keyboard inputs.
        isFocused = 1 << 5,

        /// The semantics node has the quality of either being "enabled" or
        /// "disabled".
        ///
        /// For example, a button can be enabled or disabled and therefore has an
        /// "enabled" state. Static text is usually neither enabled nor disabled and
        /// therefore does not have an "enabled" state.
        hasEnabledState = 1 << 6,

        /// Whether a semantic node that [hasEnabledState] is currently enabled.
        ///
        /// A disabled element does not respond to user interaction. For example, a
        /// button that currently does not respond to user interaction should be
        /// marked as disabled.
        isEnabled = 1 << 7,

        /// Whether a semantic node is in a mutually exclusive group.
        ///
        /// For example, a radio button is in a mutually exclusive group because
        /// only one radio button in that group can be marked as [isChecked].
        isInMutuallyExclusiveGroup = 1 << 8,

        /// Whether a semantic node is a header that divides content into sections.
        ///
        /// For example, headers can be used to divide a list of alphabetically
        /// sorted words into the sections A, B, C, etc. as can be found in many
        /// address book applications.
        isHeader = 1 << 9,

        /// Whether the value of the semantics node is obscured.
        ///
        /// This is usually used for text fields to indicate that its content
        /// is a password or contains other sensitive information.
        isObscured = 1 << 10,

        /// Whether the semantics node is the root of a subtree for which a route name
        /// should be announced.
        ///
        /// When a node with this flag is removed from the semantics tree, the
        /// framework will select the last in depth-first, paint order node with this
        /// flag.  When a node with this flag is added to the semantics tree, it is
        /// selected automatically, unless there were multiple nodes with this flag
        /// added.  In this case, the last added node in depth-first, paint order
        /// will be selected.
        ///
        /// From this selected node, the framework will search in depth-first, paint
        /// order for the first node with a [namesRoute] flag and a non-null,
        /// non-empty label. The [namesRoute] and [scopesRoute] flags may be on the
        /// same node. The label of the found node will be announced as an edge
        /// transition. If no non-empty, non-null label is found then:
        ///
        ///   * VoiceOver will make a chime announcement.
        ///   * TalkBack will make no announcement
        ///
        /// Semantic nodes annotated with this flag are generally not a11y focusable.
        ///
        /// This is used in widgets such as Routes, Drawers, and Dialogs to
        /// communicate significant changes in the visible screen.
        scopesRoute = 1 << 11,

        /// Whether the semantics node label is the name of a visually distinct
        /// route.
        ///
        /// This is used by certain widgets like Drawers and Dialogs, to indicate
        /// that the node's semantic label can be used to announce an edge triggered
        /// semantics update.
        ///
        /// Semantic nodes annotated with this flag will still recieve a11y focus.
        ///
        /// Updating this label within the same active route subtree will not cause
        /// additional announcements.
        namesRoute = 1 << 12,

        /// Whether the semantics node is considered hidden.
        ///
        /// Hidden elements are currently not visible on screen. They may be covered
        /// by other elements or positioned outside of the visible area of a viewport.
        ///
        /// Hidden elements cannot gain accessibility focus though regular touch. The
        /// only way they can be focused is by moving the focus to them via linear
        /// navigation.
        ///
        /// Platforms are free to completely ignore hidden elements and new platforms
        /// are encouraged to do so.
        ///
        /// Instead of marking an element as hidden it should usually be excluded from
        /// the semantics tree altogether. Hidden elements are only included in the
        /// semantics tree to work around platform limitations and they are mainly
        /// used to implement accessibility scrolling on iOS.
        isHidden = 1 << 13,

        /// Whether the semantics node represents an image.
        ///
        /// Both TalkBack and VoiceOver will inform the user the the semantics node
        /// represents an image.
        isImage = 1 << 14,

        /// Whether the semantics node is a live region.
        ///
        /// A live region indicates that updates to semantics node are important.
        /// Platforms may use this information to make polite announcements to the
        /// user to inform them of updates to this node.
        ///
        /// An example of a live region is a [SnackBar] widget. On Android, A live
        /// region causes a polite announcement to be generated automatically, even
        /// if the user does not have focus of the widget.
        isLiveRegion = 1 << 15,

        /// The semantics node has the quality of either being "on" or "off".
        ///
        /// This flag is mutually exclusive with [hasCheckedState].
        ///
        /// For example, a switch has toggled state.
        ///
        /// See also:
        ///
        ///    * [SemanticsFlag.isToggled], which controls whether the node is "on" or "off".
        hasToggledState = 1 << 16,

        /// If true, the semantics node is "on". If false, the semantics node is
        /// "off".
        ///
        /// For example, if a switch is in the on position, [isToggled] is true.
        ///
        /// See also:
        ///
        ///   * [SemanticsFlag.hasToggledState], which enables a toggled state.
        isToggled = 1 << 17,

        /// Whether the platform can scroll the semantics node when the user attempts
        /// to move focus to an offscreen child.
        ///
        /// For example, a [ListView] widget has implicit scrolling so that users can
        /// easily move to the next visible set of children. A [TabBar] widget does
        /// not have implicit scrolling, so that users can navigate into the tab
        /// body when reaching the end of the tab bar.
        hasImplicitScrolling = 1 << 18
    }

    /// An object that creates [SemanticsUpdate] objects.
    ///
    /// Once created, the [SemanticsUpdate] objects can be passed to
    /// [Window.updateSemantics] to update the semantics conveyed to the user.
    public class SemanticsUpdateBuilder
    {
        SemanticsNodeUpdates nodes_;
        CustomAccessibilityActionUpdates actions_;

        /// Creates an empty [SemanticsUpdateBuilder] object.
        //@pragma('vm:entry-point')
        public SemanticsUpdateBuilder() { }

        /// Update the information associated with the node with the given `id`.
        ///
        /// The semantics nodes form a tree, with the root of the tree always having
        /// an id of zero. The `childrenInTraversalOrder` and `childrenInHitTestOrder`
        /// are the ids of the nodes that are immediate children of this node. The
        /// former enumerates children in traversal order, and the latter enumerates
        /// the same children in the hit test order. The two lists must have the same
        /// length and contain the same ids. They may only differ in the order the
        /// ids are listed in. For more information about different child orders, see
        /// [DebugSemanticsDumpOrder].
        ///
        /// The system retains the nodes that are currently reachable from the root.
        /// A given update need not contain information for nodes that do not change
        /// in the update. If a node is not reachable from the root after an update,
        /// the node will be discarded from the tree.
        ///
        /// The `flags` are a bit field of [SemanticsFlag]s that apply to this node.
        ///
        /// The `actions` are a bit field of [SemanticsAction]s that can be undertaken
        /// by this node. If the user wishes to undertake one of these actions on this
        /// node, the [Window.onSemanticsAction] will be called with `id` and one of
        /// the possible [SemanticsAction]s. Because the semantics tree is maintained
        /// asynchronously, the [Window.onSemanticsAction] callback might be called
        /// with an action that is no longer possible.
        ///
        /// The `label` is a string that describes this node. The `value` property
        /// describes the current value of the node as a string. The `increasedValue`
        /// string will become the `value` string after a [SemanticsAction.increase]
        /// action is performed. The `decreasedValue` string will become the `value`
        /// string after a [SemanticsAction.decrease] action is performed. The `hint`
        /// string describes what result an action performed on this node has. The
        /// reading direction of all these strings is given by `textDirection`.
        ///
        /// The fields 'textSelectionBase' and 'textSelectionExtent' describe the
        /// currently selected text within `value`.
        ///
        /// For scrollable nodes `scrollPosition` describes the current scroll
        /// position in logical pixel. `scrollExtentMax` and `scrollExtentMin`
        /// describe the maximum and minimum in-rage values that `scrollPosition` can
        /// be. Both or either may be infinity to indicate unbound scrolling. The
        /// value for `scrollPosition` can (temporarily) be outside this range, for
        /// example during an overscroll. `scrollChildren` is the count of the
        /// total number of child nodes that contribute semantics and `scrollIndex`
        /// is the index of the first visible child node that contributes semantics.
        ///
        /// The `rect` is the region occupied by this node in its own coordinate
        /// system.
        ///
        /// The `transform` is a matrix that maps this node's coordinate system into
        /// its parent's coordinate system.
        public void updateNode(
            int id = 0,
            SemanticsFlag flags = 0,
            SemanticsAction actions = 0,
            int textSelectionBase = 0,
            int textSelectionExtent = 0,
            int scrollChildren = 0,
            int scrollIndex = 0,
            double scrollPosition = 0.0,
            double scrollExtentMax = 0.0,
            double scrollExtentMin = 0.0,
            Rect rect = null,
            String label = null,
            String hint = null,
            String value = null,
            String increasedValue = null,
            String decreasedValue = null,
            TextDirection textDirection = TextDirection.ltr,
            SKMatrix44 transform = null,
            List<int> childrenInTraversalOrder = null,
            List<int> childrenInHitTestOrder = null,
            List<int> additionalActions = null)
        {
            SemanticsNode node = new SemanticsNode
            {
                id                         = id,
                flags                      = flags,
                actions                    = actions,
                textSelectionBase          = textSelectionBase,
                textSelectionExtent        = textSelectionExtent,
                scrollChildren             = scrollChildren,
                scrollIndex                = scrollIndex,
                scrollPosition             = scrollPosition,
                scrollExtentMax            = scrollExtentMax,
                scrollExtentMin            = scrollExtentMin,
                rect                       = rect.ToSKRect(),
                label                      = label,
                hint                       = hint,
                value                      = value,
                increasedValue             = increasedValue,
                decreasedValue             = decreasedValue,
                textDirection              = textDirection,
                transform                  = transform,
                childrenInTraversalOrder   = childrenInTraversalOrder,
                childrenInHitTestOrder     = childrenInHitTestOrder,
                customAccessibilityActions = additionalActions
            };
            nodes_[id] = node;
        }

        /// Update the custom semantics action associated with the given `id`.
        ///
        /// The name of the action exposed to the user is the `label`. For overriden
        /// standard actions this value is ignored.
        ///
        /// The `hint` should describe what happens when an action occurs, not the
        /// manner in which a tap is accomplished. For example, use "delete" instead
        /// of "double tap to delete".
        ///
        /// The text direction of the `hint` and `label` is the same as the global
        /// window.
        ///
        /// For overriden standard actions, `overrideId` corresponds with a
        /// [SemanticsAction.index] value. For custom actions this argument should not be
        /// provided.
        public void updateCustomAction(
            int id = 0,
            string label = "",
            string hint = "",
            int overrideId = -1)
        {
            //assert(id != null);
            //assert(overrideId != null);

            CustomAccessibilityAction action = new CustomAccessibilityAction
            {
                id         = id,
                overrideId = overrideId,
                label      = label,
                hint       = hint
            };
            actions_[id] = action;
        }

        /// Creates a [SemanticsUpdate] object that encapsulates the updates recorded
        /// by this object.
        ///
        /// The returned object can be passed to [Window.updateSemantics] to actually
        /// update the semantics retained by the system.
        public SemanticsUpdate build()
        {
            return new SemanticsUpdate(nodes_, actions_);
        }
    }

    /// An opaque object representing a batch of semantics updates.
    ///
    /// To create a SemanticsUpdate object, use a [SemanticsUpdateBuilder].
    ///
    /// Semantics updates can be applied to the system's retained semantics tree
    /// using the [Window.updateSemantics] method.
    public class SemanticsUpdate
    {
        SemanticsNodeUpdates nodes_;
        CustomAccessibilityActionUpdates actions_;

        /// This class is created by the engine, and should not be instantiated
        /// or extended directly.
        ///
        /// To create a SemanticsUpdate object, use a [SemanticsUpdateBuilder].
        //@pragma('vm:entry-point')
        public SemanticsUpdate(
            SemanticsNodeUpdates nodes,
            CustomAccessibilityActionUpdates actions)
        {
            this.nodes_   = nodes;
            this.actions_ = actions;
        }

        public SemanticsNodeUpdates takeNodes() => nodes_;

        public CustomAccessibilityActionUpdates takeActions() => actions_;
    }

    public class CustomAccessibilityActionUpdates : Dictionary<int, CustomAccessibilityAction> { }

    public class SemanticsNodeUpdates : Dictionary<int, SemanticsNode> { }

    /// A custom accessibility action is used to indicate additional semantics
    /// actions that a user can perform on a semantics node beyond the
    /// preconfigured options.
    public class CustomAccessibilityAction
    {
        public int id = 0;
        public int overrideId = -1;
        public string label;
        public string hint;
    }


    public class SemanticsNode
    {
        public bool HasAction(SemanticsAction action) => actions.HasFlag(action);

        public bool HasFlag(SemanticsFlag flag) => flags.HasFlag(flag);

        public int id = 0;
        public SemanticsFlag flags;
        public SemanticsAction actions;
        public int textSelectionBase = -1;
        public int textSelectionExtent = -1;
        public int scrollChildren = 0;
        public int scrollIndex = 0;
        public double scrollPosition = double.NaN;
        public double scrollExtentMax = double.NaN;
        public double scrollExtentMin = double.NaN;
        public string label;
        public string hint;
        public string value;
        public string increasedValue;
        public string decreasedValue;
        public TextDirection textDirection;

        public SKRect rect = SKRect.Empty;
        public SKMatrix44 transform = SKMatrix44.CreateIdentity();
        public List<int> childrenInTraversalOrder = new List<int>();
        public List<int> childrenInHitTestOrder = new List<int>();
        public List<int> customAccessibilityActions = new List<int>();
    }
}
