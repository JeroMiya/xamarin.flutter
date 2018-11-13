using FlutterBinding.UI;
using System;
using System.Collections.Generic;

namespace FlutterBinding.Mapping
{
    public static class Types
    {
        public enum Endian
        {
            big,
            little
        }
        
        public class Duration
        {
            public Duration(long milliseconds = 0, long microseconds = 0)
            {

            }

            public static Duration zero = new Duration(); //TODO: make an actual zero
        }

        public class ByteData
        {
            public ByteData() { }
            public ByteData(int value) { }

            public int getInt32(int first, int second) => 0; // TODO:
            public int getInt64(int first, int second) => 0; // TODO:
            public double getFloat64(int first, int second) => 0; // TODO:
            public double getFloat32(int first, int second) => 0; // TODO:

            public void setInt32(int first, int second, int third) { }
            public void setFloat32(double first, double second, int third) { }

            public int lengthInBytes => 0; // TODO;

            public static ByteData asByteData(List<int> list) => new ByteData(); // TODO:
        }

        public class Zone
        {
            public static Zone current = new Zone();
            public void runUnaryGuarded(PlatformMessageResponseCallback callback, ByteData data)
            {
                // TODO:
            }

            public void runUnaryGuarded<A>(Action<A> callback, A data)
            {
                // TODO:
            }

            public void runGuarded(VoidCallback callback)
            {
                // TODO:
            }

            public void runBinaryGuarded<A1, A2>(Action<A1, A2> callback, A1 arg1, A2 arg2)
            {
                // TODO:
            }
        }

        public class StateError : Exception {
            public StateError(string message) : base(message) { }
        }

    }

    public class Uint8List : List<byte>
    {
        /// <inheritdoc />
        public Uint8List() { }

        /// <inheritdoc />
        public Uint8List(IEnumerable<byte> collection) : base(collection) { }

        /// <inheritdoc />
        public Uint8List(int capacity) : base(capacity) { }
    }

    public class Int8List : List<sbyte>
    {
        /// <inheritdoc />
        public Int8List() { }

        /// <inheritdoc />
        public Int8List(IEnumerable<sbyte> collection) : base(collection) { }

        /// <inheritdoc />
        public Int8List(int capacity) : base(capacity) { }
    }

    public class Uint16List : List<UInt16>
    {
        /// <inheritdoc />
        public Uint16List() { }

        /// <inheritdoc />
        public Uint16List(IEnumerable<ushort> collection) : base(collection) { }

        /// <inheritdoc />
        public Uint16List(int capacity) : base(capacity) { }
    }

    public class Int16List : List<Int16>
    {
        /// <inheritdoc />
        public Int16List() { }

        /// <inheritdoc />
        public Int16List(IEnumerable<short> collection) : base(collection) { }

        /// <inheritdoc />
        public Int16List(int capacity) : base(capacity) { }
    }

    public class Uint32List : List<UInt32>
    {
        /// <inheritdoc />
        public Uint32List() { }

        /// <inheritdoc />
        public Uint32List(IEnumerable<uint> collection) : base(collection) { }

        /// <inheritdoc />
        public Uint32List(int capacity) : base(capacity) { }
    }

    public class Int32List : List<Int32>
    {
        /// <inheritdoc />
        public Int32List() { }

        /// <inheritdoc />
        public Int32List(IEnumerable<int> collection) : base(collection) { }

        /// <inheritdoc />
        public Int32List(int capacity) : base(capacity) { }
    }

    public class Uint64List : List<UInt64>
    {
        /// <inheritdoc />
        public Uint64List() { }

        /// <inheritdoc />
        public Uint64List(IEnumerable<ulong> collection) : base(collection) { }

        /// <inheritdoc />
        public Uint64List(int capacity) : base(capacity) { }
    }

    public class Int64List : List<Int64>
    {
        /// <inheritdoc />
        public Int64List() { }

        /// <inheritdoc />
        public Int64List(IEnumerable<long> collection) : base(collection) { }

        /// <inheritdoc />
        public Int64List(int capacity) : base(capacity) { }
    }

    public class Float32List : List<double>
    {
        /// <inheritdoc />
        public Float32List() { }

        /// <inheritdoc />
        public Float32List(IEnumerable<double> collection) : base(collection) { }

        /// <inheritdoc />
        public Float32List(int capacity) : base(capacity) { }
    }

    public class Float64List : List<float>
    {
        /// <inheritdoc />
        public Float64List() { }

        /// <inheritdoc />
        public Float64List(IEnumerable<float> collection) : base(collection) { }

        /// <inheritdoc />
        public Float64List(int capacity) : base(capacity) { }
    }

}
