using System;
using FlutterBinding.Engine;

namespace FlutterBinding.Mapping
{
    /// <summary>
    /// The Dart lang uses Duration as a pseudonym for c# TimeSpan or FML c++ TimeDelta
    /// </summary>
    public class Duration : TimeDelta
    {
    }


    /*
    public readonly struct Duration : IComparable, IComparable<Duration>, IEquatable<Duration>
    {
        public const long TicksPerMicrosecond = 10;
        private const double MicrosecondsPerTick = 1.0 / TicksPerMicrosecond; // 0.1

        public const long TicksPerMillisecond = 10000;
        private const double MillisecondsPerTick = 1.0 / TicksPerMillisecond;

        public const long TicksPerSecond = TicksPerMillisecond * 1000; // 10,000,000
        private const double SecondsPerTick = 1.0 / TicksPerSecond;    // 0.0000001

        public const long TicksPerMinute = TicksPerSecond * 60;     // 600,000,000
        private const double MinutesPerTick = 1.0 / TicksPerMinute; // 1.6666666666667e-9

        public const long TicksPerHour = TicksPerMinute * 60;   // 36,000,000,000
        private const double HoursPerTick = 1.0 / TicksPerHour; // 2.77777777777777778e-11

        public const long TicksPerDay = TicksPerHour * 24;    // 864,000,000,000
        private const double DaysPerTick = 1.0 / TicksPerDay; // 1.1574074074074074074e-12

        private const int MillisPerSecond = 1000;
        private const int MillisPerMinute = MillisPerSecond * 60; //     60,000
        private const int MillisPerHour = MillisPerMinute * 60;   //  3,600,000
        private const int MillisPerDay = MillisPerHour * 24;      // 86,400,000

        internal const long MaxSeconds = long.MaxValue / TicksPerSecond;
        internal const long MinSeconds = long.MinValue / TicksPerSecond;

        internal const long MaxMilliSeconds = long.MaxValue / TicksPerMillisecond;
        internal const long MinMilliSeconds = long.MinValue / TicksPerMillisecond;

        internal const long TicksPerTenthSecond = TicksPerMillisecond * 100;

        public static readonly Duration Zero = new Duration(0);

        public static readonly Duration MaxValue = new Duration(long.MaxValue);
        public static readonly Duration MinValue = new Duration(long.MinValue);

        // internal so that DateTime doesn't have to call an extra get
        // method for some arithmetic operations.
        internal readonly long _ticks; // Do not rename (binary serialization)

        private const string Overflow_DurationTooLong = "Duration overflow";
        private const string Overflow_NegateTwosCompNum = "Negative twos comp";
        private const string Arg_MustBeDuration = "Must be Duration";
        private const string Arg_CannotBeNaN = "Cannot be NaN";

        public Duration(long ticks)
        {
            _ticks = ticks;
        }

        public Duration(int hours, int minutes, int seconds)
        {
            _ticks = TimeToTicks(hours, minutes, seconds);
        }

        public Duration(int days, int hours, int minutes, int seconds)
            : this(days, hours, minutes, seconds, 0) { }

        public Duration(int days, int hours, int minutes, int seconds, int milliseconds)
        {
            long totalMilliSeconds = ((long)days * 3600 * 24 + (long)hours * 3600 + (long)minutes * 60 + seconds) * 1000 + milliseconds;
            if (totalMilliSeconds > MaxMilliSeconds || totalMilliSeconds < MinMilliSeconds)
                throw new ArgumentOutOfRangeException(null, Overflow_DurationTooLong);
            _ticks = (long)totalMilliSeconds * TicksPerMillisecond;
        }

        public long Ticks => _ticks;

        public int Microseconds => (int)((_ticks / TicksPerMicrosecond) % 10);

        public int Milliseconds => (int)((_ticks / TicksPerMillisecond) % 1000);

        public int Seconds => (int)((_ticks / TicksPerSecond) % 60);

        public int Minutes => (int)((_ticks / TicksPerMinute) % 60);

        public int Hours => (int)((_ticks / TicksPerHour) % 24);

        public int Days => (int)(_ticks / TicksPerDay);

        public double TotalDays => ((double)_ticks) * DaysPerTick;

        public double TotalHours => (double)_ticks * HoursPerTick;

        public double TotalMinutes => (double)_ticks * MinutesPerTick;

        public double TotalSeconds => (double)_ticks * SecondsPerTick;

        public double TotalMilliseconds
        {
            get
            {
                double temp = (double)_ticks * MillisecondsPerTick;
                if (temp > MaxMilliSeconds)
                    return (double)MaxMilliSeconds;

                if (temp < MinMilliSeconds)
                    return (double)MinMilliSeconds;

                return temp;
            }
        }

        public double TotalMicroseconds => (double)_ticks * MicrosecondsPerTick;

        public Duration Add(Duration ts)
        {
            long result = _ticks + ts._ticks;
            // Overflow if signs of operands was identical and result's
            // sign was opposite.
            // >> 63 gives the sign bit (either 64 1's or 64 0's).
            if ((_ticks >> 63 == ts._ticks >> 63) && (_ticks >> 63 != result >> 63))
                throw new OverflowException(Overflow_DurationTooLong);
            return new Duration(result);
        }


        // Compares two Duration values, returning an integer that indicates their
        // relationship.
        //
        public static int Compare(Duration t1, Duration t2)
        {
            if (t1._ticks > t2._ticks) return 1;
            if (t1._ticks < t2._ticks) return -1;
            return 0;
        }

        // Returns a value less than zero if this  object
        public int CompareTo(object value)
        {
            if (value == null) return 1;
            if (!(value is Duration))
                throw new ArgumentException(Arg_MustBeDuration);
            long t = ((Duration)value)._ticks;
            if (_ticks > t) return 1;
            if (_ticks < t) return -1;
            return 0;
        }

        public int CompareTo(Duration value)
        {
            long t = value._ticks;
            if (_ticks > t) return 1;
            if (_ticks < t) return -1;
            return 0;
        }

        public static Duration FromDays(double value)
        {
            return Interval(value, MillisPerDay);
        }

        //public Duration Duration()
        //{
        //    if (Ticks == Duration.MinValue.Ticks)
        //        throw new OverflowException(SR.Overflow_Duration);
        //    return new Duration(_ticks >= 0 ? _ticks : -_ticks);
        //}

        public override bool Equals(object value)
        {
            if (value is Duration duration)
                return _ticks == duration._ticks;

            return false;
        }

        public bool Equals(Duration obj)
        {
            return _ticks == obj._ticks;
        }

        public static bool Equals(Duration t1, Duration t2)
        {
            return t1._ticks == t2._ticks;
        }

        public override int GetHashCode()
        {
            return (int)_ticks ^ (int)(_ticks >> 32);
        }

        public static Duration FromHours(double value)
        {
            return Interval(value, MillisPerHour);
        }

        private static Duration Interval(double value, int scale)
        {
            if (double.IsNaN(value))
                throw new ArgumentException(Arg_CannotBeNaN);
            double tmp = value * scale;
            double millis = tmp + (value >= 0 ? 0.5 : -0.5);
            if ((millis > long.MaxValue / TicksPerMillisecond) || (millis < long.MinValue / TicksPerMillisecond))
                throw new OverflowException(Overflow_DurationTooLong);
            return new Duration((long)millis * TicksPerMillisecond);
        }

        public static Duration FromMilliseconds(double value)
        {
            return Interval(value, 1);
        }

        public static Duration FromMicroseconds(double value)
        {
            return new Duration((long)(value * TicksPerMicrosecond));
        }

        public static Duration FromMinutes(double value)
        {
            return Interval(value, MillisPerMinute);
        }

        public Duration Negate()
        {
            if (Ticks == Duration.MinValue.Ticks)
                throw new OverflowException(Overflow_NegateTwosCompNum);
            return new Duration(-_ticks);
        }

        public static Duration FromSeconds(double value)
        {
            return Interval(value, MillisPerSecond);
        }

        public Duration Subtract(Duration ts)
        {
            long result = _ticks - ts._ticks;
            // Overflow if signs of operands was different and result's
            // sign was opposite from the first argument's sign.
            // >> 63 gives the sign bit (either 64 1's or 64 0's).
            if ((_ticks >> 63 != ts._ticks >> 63) && (_ticks >> 63 != result >> 63))
                throw new OverflowException(Overflow_DurationTooLong);
            return new Duration(result);
        }

        public Duration Multiply(double factor)
        {
            return this * factor;
        }

        public Duration Divide(double divisor)
        {
            return this / divisor;
        }

        public double Divide(Duration ts)
        {
            return this / ts;
        }

        public static Duration FromTicks(long value)
        {
            return new Duration(value);
        }

        internal static long TimeToTicks(int hour, int minute, int second)
        {
            // totalSeconds is bounded by 2^31 * 2^12 + 2^31 * 2^8 + 2^31,
            // which is less than 2^44, meaning we won't overflow totalSeconds.
            long totalSeconds = (long)hour * 3600 + (long)minute * 60 + (long)second;
            if (totalSeconds > MaxSeconds || totalSeconds < MinSeconds)
                throw new ArgumentOutOfRangeException(null, Overflow_DurationTooLong);
            return totalSeconds * TicksPerSecond;
        }

        public override string ToString()
        {
            if (Days == 0)
            {
                if (Milliseconds != 0)
                    return $"{Hours:02}:{Minutes:02}:{Seconds:02}.{Milliseconds:03}.{Microseconds}";
                return $"{Hours:02}:{Minutes:02}:{Seconds:02}";
            }

            if (Milliseconds != 0)
                return $"{Days:02}:{Hours:02}:{Minutes:02}:{Seconds:02}.{Milliseconds:03}.{Microseconds}";
            return $"{Days:02}:{Hours:02}:{Minutes:02}:{Seconds:02}";
        }

        public static Duration operator -(Duration t)
        {
            if (t._ticks == Duration.MinValue._ticks)
                throw new OverflowException(Overflow_NegateTwosCompNum);
            return new Duration(-t._ticks);
        }

        public static Duration operator -(Duration t1, Duration t2)
        {
            return t1.Subtract(t2);
        }

        public static Duration operator +(Duration t)
        {
            return t;
        }

        public static Duration operator +(Duration t1, Duration t2)
        {
            return t1.Add(t2);
        }

        public static Duration operator *(Duration timeSpan, double factor)
        {
            if (double.IsNaN(factor))
            {
                throw new ArgumentException(Arg_CannotBeNaN, nameof(factor));
            }

            // Rounding to the nearest tick is as close to the result we would have with unlimited
            // precision as possible, and so likely to have the least potential to surprise.
            double ticks = Math.Round(timeSpan.Ticks * factor);
            if (ticks > long.MaxValue | ticks < long.MinValue)
            {
                throw new OverflowException(Overflow_DurationTooLong);
            }

            return FromTicks((long)ticks);
        }

        public static Duration operator *(double factor, Duration timeSpan)
        {
            return timeSpan * factor;
        }

        public static Duration operator /(Duration timeSpan, double divisor)
        {
            if (double.IsNaN(divisor))
            {
                throw new ArgumentException(Arg_CannotBeNaN, nameof(divisor));
            }

            double ticks = Math.Round(timeSpan.Ticks / divisor);
            if (ticks > long.MaxValue | ticks < long.MinValue || double.IsNaN(ticks))
            {
                throw new OverflowException(Overflow_DurationTooLong);
            }

            return FromTicks((long)ticks);
        }

        // Using floating-point arithmetic directly means that infinities can be returned, which is reasonable
        // if we consider Duration.FromHours(1) / Duration.Zero asks how many zero-second intervals there are in
        // an hour for which infinity is the mathematic correct answer. Having Duration.Zero / Duration.Zero return NaN
        // is perhaps less useful, but no less useful than an exception.
        public static double operator /(Duration t1, Duration t2)
        {
            return t1.Ticks / (double)t2.Ticks;
        }

        public static bool operator ==(Duration t1, Duration t2)
        {
            return t1._ticks == t2._ticks;
        }

        public static bool operator !=(Duration t1, Duration t2)
        {
            return t1._ticks != t2._ticks;
        }

        public static bool operator <(Duration t1, Duration t2)
        {
            return t1._ticks < t2._ticks;
        }

        public static bool operator <=(Duration t1, Duration t2)
        {
            return t1._ticks <= t2._ticks;
        }

        public static bool operator >(Duration t1, Duration t2)
        {
            return t1._ticks > t2._ticks;
        }

        public static bool operator >=(Duration t1, Duration t2)
        {
            return t1._ticks >= t2._ticks;
        }
    }
    */
}
