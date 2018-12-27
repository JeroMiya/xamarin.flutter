using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Flutter.Shell.Droid.View;
using FlutterBinding.Engine;
using FlutterBinding.Shell;

namespace Flutter.Shell.Droid
{
    public class AndroidPlatformView : PlatformView
    {
        private readonly FlutterNativeView _view;

        /// <inheritdoc />
        public AndroidPlatformView(
            Delegate @delegate,
            TaskRunners taskRunners, 
            FlutterNativeView view) 
            : base(@delegate, taskRunners)
        {
            _view = view;
        }
    }
}