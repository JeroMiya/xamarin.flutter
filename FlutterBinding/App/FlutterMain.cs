using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using FlutterBinding.Shell;
using TinyIoC;

namespace FlutterBinding.App
{
    public static class FlutterMain
    {
        private static TaskCompletionSource<bool> _initTcs;
        public static Settings Settings { get; private set; }
        private static Stopwatch _stopwatch;

        public static bool IsInitialized
        {
            get
            {
                if (_initTcs == null)
                    return false;
                return _initTcs.Task.IsCompleted && _initTcs.Task.Result;
            }
        }

        public static Task InitializationTask => _initTcs?.Task;

        public static TinyIoCContainer Container => TinyIoCContainer.Current;

        public static Task Initialize(Settings settings = null, Action<TinyIoCContainer> dependencyInjectionAction = null)
        {
            if (_initTcs != null)
                return _initTcs.Task;
            _initTcs = new TaskCompletionSource<bool>();

            // Flutter Settings
            Settings = settings ?? new Settings();

            // Global stopwatch for accuracy
            _stopwatch = new Stopwatch();
            _stopwatch.Start();

            // Platform to populate IoC
            dependencyInjectionAction?.Invoke(Container);

            return _initTcs.Task;
        }
        
    }
}
