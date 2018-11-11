using System;
using System.Collections.Generic;
using FlutterBinding.UI;
using SkiaSharp;

namespace FlutterBinding.Engine.Semantics
{
    // Must match the SemanticsAction enum in semantics.dart.
    [Flags]
    public enum SemanticsAction
    {
        /// The equivalent of a user briefly tapping the screen with the finger
        /// without moving it.
        Tap = 1 << 0,

        /// The equivalent of a user pressing and holding the screen with the finger
        /// for a few seconds without moving it.
        LongPress = 1 << 1,

        /// The equivalent of a user moving their finger across the screen from right
        /// to left.
        ///
        /// This action should be recognized by controls that are horizontally
        /// scrollable.
        ScrollLeft = 1 << 2,

        /// The equivalent of a user moving their finger across the screen from left
        /// to right.
        ///
        /// This action should be recognized by controls that are horizontally
        /// scrollable.
        ScrollRight = 1 << 3,

        /// The equivalent of a user moving their finger across the screen from
        /// bottom to top.
        ///
        /// This action should be recognized by controls that are vertically
        /// scrollable.
        ScrollUp = 1 << 4,

        /// The equivalent of a user moving their finger across the screen from top
        /// to bottom.
        ///
        /// This action should be recognized by controls that are vertically
        /// scrollable.
        ScrollDown = 1 << 5,

        /// A request to increase the value represented by the semantics node.
        ///
        /// For example, this action might be recognized by a slider control.
        Increase = 1 << 6,

        /// A request to decrease the value represented by the semantics node.
        ///
        /// For example, this action might be recognized by a slider control.
        Decrease = 1 << 7,

        /// A request to fully show the semantics node on screen.
        ///
        /// For example, this action might be send to a node in a scrollable list that
        /// is partially off screen to bring it on screen.
        ShowOnScreen = 1 << 8,

        /// Move the cursor forward by one character.
        ///
        /// This is for example used by the cursor control in text fields.
        ///
        /// The action includes a boolean argument, which indicates whether the cursor
        /// movement should extend (or start) a selection.
        MoveCursorForwardByCharacter = 1 << 9,

        /// Move the cursor backward by one character.
        ///
        /// This is for example used by the cursor control in text fields.
        ///
        /// The action includes a boolean argument, which indicates whether the cursor
        /// movement should extend (or start) a selection.
        MoveCursorBackwardByCharacter = 1 << 10,

        /// Set the text selection to the given range.
        ///
        /// The provided argument is a Map<String, int> which includes the keys `base`
        /// and `extent` indicating where the selection within the `value` of the
        /// semantics node should start and where it should end. Values for both
        /// keys can range from 0 to length of `value` (inclusive).
        ///
        /// Setting `base` and `extent` to the same value will move the cursor to
        /// that position (without selecting anything).
        SetSelection = 1 << 11,

        /// Copy the current selection to the clipboard.
        Copy = 1 << 12,

        /// Cut the current selection and place it in the clipboard.
        Cut = 1 << 13,

        /// Paste the current content of the clipboard.
        Paste = 1 << 14,

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
        DidGainAccessibilityFocus = 1 << 15,

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
        DidLoseAccessibilityFocus = 1 << 16,

        /// Indicates that the user has invoked a custom accessibility action.
        ///
        /// This handler is added automatically whenever a custom accessibility
        /// action is added to a semantics node.
        CustomAction = 1 << 17,

        /// A request that the node should be dismissed.
        ///
        /// A [Snackbar], for example, may have a dismiss action to indicate to the
        /// user that it can be removed after it is no longer relevant. On Android,
        /// (with TalkBack) special hint text is spoken when focusing the node and
        /// a custom action is availible in the local context menu. On iOS,
        /// (with VoiceOver) users can perform a standard gesture to dismiss it.
        Dismiss = 1 << 18,

        /// Move the cursor forward by one word.
        ///
        /// This is for example used by the cursor control in text fields.
        ///
        /// The action includes a boolean argument, which indicates whether the cursor
        /// movement should extend (or start) a selection.
        MoveCursorForwardByWord = 1 << 19,

        /// Move the cursor backward by one word.
        ///
        /// This is for example used by the cursor control in text fields.
        ///
        /// The action includes a boolean argument, which indicates whether the cursor
        /// movement should extend (or start) a selection.
        MoveCursorBackwardByWord = 1 << 20,

        /// Can scroll in any direction
        ScrollableSemanticsActions = ScrollLeft | ScrollRight | ScrollUp | ScrollDown
    };

    // Must match the SemanticsFlags enum in semantics.dart.
    [Flags]
    public enum SemanticsFlags
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
        HasCheckedState = 1 << 0,

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
        IsChecked = 1 << 1,

        /// Whether a semantics node is selected.
        ///
        /// If true, the semantics node is "selected". If false, the semantics node is
        /// "unselected".
        ///
        /// For example, the active tab in a tab bar has [isSelected] set to true.
        IsSelected = 1 << 2,

        /// Whether the semantic node represents a button.
        ///
        /// Platforms has special handling for buttons, for example Android's TalkBack
        /// and iOS's VoiceOver provides an additional hint when the focused object is
        /// a button.
        IsButton = 1 << 3,

        /// Whether the semantic node represents a text field.
        ///
        /// Text fields are announced as such and allow text input via accessibility
        /// affordances.
        IsTextField = 1 << 4,

        /// Whether the semantic node currently holds the user's focus.
        ///
        /// The focused element is usually the current receiver of keyboard inputs.
        IsFocused = 1 << 5,

        /// The semantics node has the quality of either being "enabled" or
        /// "disabled".
        ///
        /// For example, a button can be enabled or disabled and therefore has an
        /// "enabled" state. Static text is usually neither enabled nor disabled and
        /// therefore does not have an "enabled" state.
        HasEnabledState = 1 << 6,

        /// Whether a semantic node that [hasEnabledState] is currently enabled.
        ///
        /// A disabled element does not respond to user interaction. For example, a
        /// button that currently does not respond to user interaction should be
        /// marked as disabled.
        IsEnabled = 1 << 7,

        /// Whether a semantic node is in a mutually exclusive group.
        ///
        /// For example, a radio button is in a mutually exclusive group because
        /// only one radio button in that group can be marked as [isChecked].
        IsInMutuallyExclusiveGroup = 1 << 8,

        /// Whether a semantic node is a header that divides content into sections.
        ///
        /// For example, headers can be used to divide a list of alphabetically
        /// sorted words into the sections A, B, C, etc. as can be found in many
        /// address book applications.
        IsHeader = 1 << 9,

        /// Whether the value of the semantics node is obscured.
        ///
        /// This is usually used for text fields to indicate that its content
        /// is a password or contains other sensitive information.
        IsObscured = 1 << 10,

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
        ScopesRoute = 1 << 11,

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
        NamesRoute = 1 << 12,

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
        IsHidden = 1 << 13,

        /// Whether the semantics node represents an image.
        ///
        /// Both TalkBack and VoiceOver will inform the user the the semantics node
        /// represents an image.
        IsImage = 1 << 14,

        /// Whether the semantics node is a live region.
        ///
        /// A live region indicates that updates to semantics node are important.
        /// Platforms may use this information to make polite announcements to the
        /// user to inform them of updates to this node.
        ///
        /// An example of a live region is a [SnackBar] widget. On Android, A live
        /// region causes a polite announcement to be generated automatically, even
        /// if the user does not have focus of the widget.
        IsLiveRegion = 1 << 15,

        /// The semantics node has the quality of either being "on" or "off".
        ///
        /// This flag is mutually exclusive with [hasCheckedState].
        ///
        /// For example, a switch has toggled state.
        ///
        /// See also:
        ///
        ///    * [SemanticsFlag.isToggled], which controls whether the node is "on" or "off".
        HasToggledState = 1 << 16,

        /// If true, the semantics node is "on". If false, the semantics node is
        /// "off".
        ///
        /// For example, if a switch is in the on position, [isToggled] is true.
        ///
        /// See also:
        ///
        ///   * [SemanticsFlag.hasToggledState], which enables a toggled state.
        IsToggled = 1 << 17,

        /// Whether the platform can scroll the semantics node when the user attempts
        /// to move focus to an offscreen child.
        ///
        /// For example, a [ListView] widget has implicit scrolling so that users can
        /// easily move to the next visible set of children. A [TabBar] widget does
        /// not have implicit scrolling, so that users can navigate into the tab
        /// body when reaching the end of the tab bar.
        HasImplicitScrolling = 1 << 18,
    };


    public class SemanticsNode
    {
        public bool HasAction(SemanticsAction action) => actions.HasFlag(action);

        public bool HasFlag(SemanticsFlags flag) => flags.HasFlag(flag);

        public int id = 0;
        public SemanticsFlags flags = 0;
        public SemanticsAction actions = 0;
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
        public TextDirection textDirection = 0; // 0=unknown, 1=rtl, 2=ltr

        public SKRect rect = SKRect.Empty;
        public SKMatrix44 transform = SKMatrix44.CreateIdentity();
        public List<int> childrenInTraversalOrder;
        public List<int> childrenInHitTestOrder;
        public List<int> customAccessibilityActions;
    }

    public class SemanticsNodeUpdates : Dictionary<int, SemanticsNode> { }
}
