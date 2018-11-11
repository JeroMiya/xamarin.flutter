using System;
using System.Collections.Generic;
using System.Linq;
using FlutterBinding.Engine.Semantics;
using FlutterBinding.Mapping;
using SkiaSharp;

namespace FlutterBinding.UI
{
    /// An object that creates [SemanticsUpdate] objects.
    ///
    /// Once created, the [SemanticsUpdate] objects can be passed to
    /// [Window.updateSemantics] to update the semantics conveyed to the user.
    public class SemanticsUpdateBuilder : NativeFieldWrapperClass2
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
            SemanticsFlags flags = 0,
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
            List<double> transform = null,
            List<int> childrenInTraversalOrder = null,
            List<int> childrenInHitTestOrder = null,
            List<int> additionalActions = null)
        {
            if (transform.Count != 16)
                throw new ArgumentException("transform argument must have 16 entries.");

            var node = new SemanticsNode
            {
                id                  = id,
                flags               = flags,
                actions             = actions,
                textSelectionBase   = textSelectionBase,
                textSelectionExtent = textSelectionExtent,
                scrollChildren      = scrollChildren,
                scrollIndex         = scrollIndex,
                scrollPosition      = scrollPosition,
                scrollExtentMax     = scrollExtentMax,
                scrollExtentMin     = scrollExtentMin,
                rect                = rect.ToSKRect(),
                label               = label,
                hint                = hint,
                value               = value,
                increasedValue      = increasedValue,
                decreasedValue      = decreasedValue,
                textDirection       = textDirection,
                transform           = SKMatrix44.FromColumnMajor(transform.Cast<float>().ToArray()),
                childrenInTraversalOrder = childrenInTraversalOrder,
                childrenInHitTestOrder = childrenInHitTestOrder,
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
        void updateCustomAction(int id = 0, String label = "", String hint = "", int overrideId = -1)
        {
            //assert(id != null);
            //assert(overrideId != null);

            CustomAccessibilityAction action = new CustomAccessibilityAction
            {
                id = id,
                overrideId = overrideId,
                label = label,
                hint = hint
            };

            actions_[id]      = action;
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
        private readonly SemanticsNodeUpdates _nodes;
        private readonly CustomAccessibilityActionUpdates _actions;

        public SemanticsNodeUpdates takeNodes() => _nodes;

        public CustomAccessibilityActionUpdates takeActions() => _actions;

        /// This class is created by the engine, and should not be instantiated
        /// or extended directly.
        ///
        /// To create a SemanticsUpdate object, use a [SemanticsUpdateBuilder].
        //@pragma('vm:entry-point')
        internal SemanticsUpdate(
            SemanticsNodeUpdates nodes,
            CustomAccessibilityActionUpdates updates)
        {
            _nodes   = nodes;
            _actions = updates;
        }
    }
}
