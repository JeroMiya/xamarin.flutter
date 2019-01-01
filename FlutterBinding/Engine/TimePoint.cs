﻿using System;

namespace FlutterBinding.Engine
{
    /// <summary>
    /// TimeDelta is the FML equivalent to .Net TimeSpan, but with a Microsecond accuracy
    /// Dart lang uses a Duration class
    /// </summary>
    public class TimeDelta
    {
        internal readonly TimeSpan _timeSpan;

        public TimeDelta(TimeSpan? ts = null)
        {
            _timeSpan = ts ?? TimeSpan.Zero;
        }

        public TimeDelta(long ticks)
        {
            _timeSpan = new TimeSpan(ticks);
        }

        public static TimeDelta operator +(TimeDelta td, TimeDelta other) => td._timeSpan + other._timeSpan;
        public static TimeDelta operator -(TimeDelta td, TimeDelta other) => td._timeSpan - other._timeSpan;
        public static TimeDelta operator %(TimeDelta td, TimeDelta other) => new TimeDelta(td._timeSpan.Ticks % other._timeSpan.Ticks);

        public static implicit operator TimeSpan(TimeDelta td) => td._timeSpan;
        public static implicit operator TimeDelta(TimeSpan td) => new TimeDelta(td);

        public static TimeDelta FromMilliseconds(double value) => new TimeDelta((long)(value * TimePoint.TicksPerMicrosecond));
        public static TimeDelta FromMicroseconds(double value) => new TimeDelta((long)(value * TimePoint.TicksPerMillisecond));
        public static TimeDelta FromSeconds(double value) => new TimeDelta((long)(value * TimePoint.TicksPerSecond));
        public static TimeDelta FromMinutes(double value) => new TimeDelta((long)(value * TimePoint.TicksPerMinute));
        public static TimeDelta FromHours(double value) => new TimeDelta((long)(value * TimePoint.TicksPerHour));
        public static TimeDelta FromDays(double value) => new TimeDelta((long)(value * TimePoint.TicksPerDay));
    }

    /// <summary>
    /// TimePoint is the FML equivalent to .Net DateTime, but with a Microsecond accuracy
    /// Dart lang also uses a DateTime class
    /// </summary>
    public class TimePoint
    {
        // Number of 100ns ticks per time unit
        public const long TicksPerMicrosecond = 10;
        public const long TicksPerMillisecond = 10000;
        public const long TicksPerSecond = TicksPerMillisecond * 1000;
        public const long TicksPerMinute = TicksPerSecond * 60;
        public const long TicksPerHour = TicksPerMinute * 60;
        public const long TicksPerDay = TicksPerHour * 24;

        // Number of milliseconds per time unit
        public const int MillisPerSecond = 1000;
        public const int MillisPerMinute = MillisPerSecond * 60;
        public const int MillisPerHour = MillisPerMinute * 60;
        public const int MillisPerDay = MillisPerHour * 24;

        private readonly DateTime _dateTime;
        private static DateTime Epoch = new DateTime(1970, 1, 1);

        public TimePoint(DateTime? dt = null)
        {
            _dateTime = dt ?? DateTime.MinValue;
        }

        public DateTime DateTime => _dateTime;
        public long Ticks => _dateTime.Ticks;
        public long TotalMicroseconds => _dateTime.Ticks / TicksPerMicrosecond;
        public long Microseconds => (_dateTime.Ticks / TicksPerMicrosecond) % 1000;

        public static implicit operator DateTime(TimePoint tp) => tp._dateTime;
        public static implicit operator TimePoint(DateTime dt) => new TimePoint(dt);

        public static TimePoint Now() => DateTime.Now;
        public static TimePoint Min() => DateTime.MinValue;
        public static TimePoint Max() => DateTime.MaxValue;

        public static TimePoint FromEpochDelta(TimeDelta ticks)
        {
            return Epoch + ticks;
        }

        TimeDelta ToEpochDelta()
        {
            return _dateTime - Epoch;
        }

        public static TimeDelta operator -(TimePoint timePoint, TimePoint other) => timePoint._dateTime - other._dateTime;
        public static TimePoint operator +(TimePoint timePoint, TimeDelta other) => timePoint._dateTime + other._timeSpan;
        public static TimePoint operator -(TimePoint timePoint, TimeDelta other) => timePoint._dateTime - other._timeSpan;

        public static bool operator <(TimePoint timePoint, TimePoint other) => timePoint._dateTime < other._dateTime;
        public static bool operator <=(TimePoint timePoint, TimePoint other) => timePoint._dateTime <= other._dateTime;
        public static bool operator >(TimePoint timePoint, TimePoint other) => timePoint._dateTime > other._dateTime;
        public static bool operator >=(TimePoint timePoint, TimePoint other) => timePoint._dateTime >= other._dateTime;


        protected bool Equals(TimePoint other)
        {
            return _dateTime.Equals(other._dateTime);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((TimePoint)obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return _dateTime.GetHashCode();
        }

        public static bool operator ==(TimePoint left, TimePoint right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TimePoint left, TimePoint right)
        {
            return !Equals(left, right);
        }
    }
}