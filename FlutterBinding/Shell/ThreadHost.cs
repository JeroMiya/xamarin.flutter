using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using FlutterBinding.Engine;

namespace FlutterBinding.Shell
{
    public class ThreadHost
    {
        [Flags]
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public enum Type
        {
            Platform = 1 << 0,
            UI = 1 << 1,
            GPU = 1 << 2,
            IO = 1 << 3
        };

        // ReSharper disable InconsistentNaming
        public TaskRunner PlatformThread { get; }
        public TaskRunner UIThread { get; }
        public TaskRunner GPUThread { get; }
        public TaskRunner IOThread { get; }
        // ReSharper restore InconsistentNaming

        public ThreadHost(string prefix, Type typeMask)
        {
            if (typeMask.HasFlag(Type.Platform))
                PlatformThread = new TaskRunner(prefix + ".platform");
            if (typeMask.HasFlag(Type.UI))
                UIThread = new TaskRunner(prefix + ".ui");
            if (typeMask.HasFlag(Type.GPU))
                GPUThread = new TaskRunner(prefix + ".gpu");
            if (typeMask.HasFlag(Type.IO))
                IOThread = new TaskRunner(prefix + ".io");
        }
    }
}
