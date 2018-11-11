using System;
using System.Collections.Generic;
using System.Text;

namespace FlutterBinding.Engine.Semantics
{
    /// A custom accessibility action is used to indicate additional semantics
    /// actions that a user can perform on a semantics node beyond the
    /// preconfigured options.
    public class CustomAccessibilityAction
    {
        public int id = 0;
        public int overrideId = -1;
        public string label;
        public string hint;
    };

    public class CustomAccessibilityActionUpdates : Dictionary<int, CustomAccessibilityAction> { }
}
