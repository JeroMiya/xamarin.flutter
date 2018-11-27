using FlutterBinding.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FlutterBinding.Mapping
{
    public static class Helper
    {
        public static bool identical(object first, object second) => first.Equals(second);

        public static int hashValues(object first, object second, object third = null, object fourth = null, object fifth = null, object sixth = null, object seventh = null, object eigth = null, object ninth = null) => 0; // TODO:

        public static int hashList(List<double> list) => 0; // TODO:
        public static int hashList(List<int> list) => 0; // TODO:

        public static string toStringAsFixed(this double value, int points)
        {
            return value.ToString($"N{points}");
        }

        public static string toRadixString(this uint value, int places) => value.ToString(); // TODO:

        public static double round(this double value) => Math.Round(value);

        public static int toInt(this double value) => Convert.ToInt32(value);

        public static int clamp(this int value, int lower, int upper)
        {
            if (value > upper)
                return upper;

            if (value < lower)
                return lower;

            return value;
        }

        public static double clamp(this double value, int lower, int upper)
        {
            if (value > upper)
                return upper;

            if (value < lower)
                return lower;

            return value;
        }

        public static bool isFinite(this double value) => !double.IsInfinity(value);

        public static double abs(this double value) => Math.Abs(value);
        
        public static Future<T> _futurize<T>(Func<T> func)
        {
            var future = new Future<T>(func);
            future.Start();
            return future;

            // NOTE: Would prefer to kill Future<> and just use Task.Run(func);
        }

        public static Future _futurize(Action action)
        {
            var future = new Future(action);
            future.Start();
            return future;
            // NOTE: Would prefer to kill Future and just use Task.Run(action);
        }

    }
}
