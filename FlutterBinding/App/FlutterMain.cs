using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlutterBinding.App
{
    public static class FlutterMain
    {
        private static TaskCompletionSource<bool> _initTcs;

        public static bool IsInitialized
        {
            get
            {
                if (_initTcs == null)
                    return false;
                return _initTcs.Task.IsCompleted && _initTcs.Task.Result;
            }
        }

        public static Task StartInitialization()
        {
            if (_initTcs != null)
                return _initTcs.Task;
            _initTcs = new TaskCompletionSource<bool>();




            return _initTcs.Task;
        }
    }
}
