using System;
using System.Collections.Generic;
using FlutterBinding.Engine;
using FlutterBinding.Mapping;
using FlutterBinding.Shell;
using static FlutterBinding.Mapping.Helper;

namespace FlutterBinding.UI
{
    // These appear to be called from the C++ Window

    public static class Hooks
    {
        public static void UpdateTextScaleFactor(double textScaleFactor)
        {
            Window.Instance.TextScaleFactor = textScaleFactor;
        }

        public static void UpdateSemanticsEnabled(bool enabled)
        {
            Window.Instance.SemanticsEnabled = enabled;
        }

        public static void UpdateAccessibilityFeatures(AccessibilityFeatures newFeatures)
        {
            Window.Instance.AccessibilityFeatures = newFeatures;
        }

        public static void DispatchPlatformMessage(PlatformMessage platformMessage)
        {
            if (Window.Instance.OnPlatformMessage != null)
            {
                Invoke(
                    () => Window.Instance.OnPlatformMessage(platformMessage),
                    Window.Instance.OnPlatformMessageZone);
            }
            //else
            //{
            //    Window.Instance.RespondToPlatformMessage(responseId, null);
            //}
        }

        public static void DispatchPointerDataPacket(Types.ByteData byteData)
        {
            var packet = UnpackPointerDataPacket(byteData);
            Window.Instance.RaisePointerDataPacket(packet);
        }

        public static void DispatchSemanticsAction(int id, SemanticsAction action, Types.ByteData args)
        {
            Window.Instance.DispatchSemanticsAction(id, action, args);
        }

        public static void BeginFrame(long microseconds)
        {
            Window.Instance.RaiseBeginFrameDelta(TimeDelta.FromMicroseconds(microseconds));
        }

        public static void DrawFrame()
        {
            Window.Instance.RaiseDrawFrame();
        }

        /// Invokes [callback] inside the given [zone].
        private static void Invoke(VoidCallback callback, Types.Zone zone)
        {
            if (callback == null)
                return;

            //assert(zone != null);

            if (identical(zone, Types.Zone.current))
            {
                callback();
            }
            else
            {
                zone.runGuarded(callback);
            }
        }

        /// Invokes [callback] inside the given [zone] passing it [arg].
        private static void Invoke1<T>(Action<T> callback, Types.Zone zone, T arg)
        {
            if (callback == null)
                return;

            if (identical(zone, Types.Zone.current))
            {
                callback(arg);
            }
            else
            {
                zone.runUnaryGuarded<T>(callback, arg);
            }
        }

        /// Invokes [callback] inside the given [zone] passing it [arg1] and [arg2].
        static void Invoke2<T1, T2>(Action<T1, T2> callback, Types.Zone zone, T1 arg1, T2 arg2)
        {
            if (callback == null)
                return;

            if (identical(zone, Types.Zone.current))
            {
                callback(arg1, arg2);
            }
            else
            {
                zone.runBinaryGuarded<T1, T2>(callback, arg1, arg2);
            }
        }

        /// Invokes [callback] inside the given [zone] passing it [arg1], [arg2] and [arg3].
        private static void Invoke3<T1, T2, T3>(Action<T1, T2, T3> callback, Types.Zone zone, T1 arg1, T2 arg2, T3 arg3)
        {
            if (callback == null)
                return;

            if (identical(zone, Types.Zone.current))
            {
                callback(arg1, arg2, arg3);
            }
            else
            {
                zone.runGuarded(() => { callback(arg1, arg2, arg3); });
            }
        }

        // If this value changes, update the encoding code in the following files:
        //
        //  * pointer_data.cc
        //  * FlutterView.java
        const int PointerDataFieldCount = 19;

        private static PointerDataPacket UnpackPointerDataPacket(Types.ByteData packet)
        {
            const int kStride = 8; // Its an 8 const anyway - Int64List.bytesPerElement;
            const int kBytesPerPointerData = PointerDataFieldCount * kStride;
            int length = packet.lengthInBytes / kBytesPerPointerData;
            List<PointerData> data = new List<PointerData>(length);
            for (int i = 0; i < length; ++i)
            {
                int offset = i * PointerDataFieldCount;
                data[i] = new PointerData(
                    timeStamp: TimeDelta.FromMicroseconds(packet.getInt64(kStride * offset++, (int)Painting.FakeHostEndian)),
                    change: (PointerChange)packet.getInt64(kStride * offset++, (int)Painting.FakeHostEndian),
                    kind: (PointerDeviceKind)packet.getInt64(kStride * offset++, (int)Painting.FakeHostEndian),
                    device: packet.getInt64(kStride * offset++, (int)Painting.FakeHostEndian),
                    physicalX: packet.getFloat64(kStride * offset++, (int)Painting.FakeHostEndian),
                    physicalY: packet.getFloat64(kStride * offset++, (int)Painting.FakeHostEndian),
                    buttons: packet.getInt64(kStride * offset++, (int)Painting.FakeHostEndian),
                    obscured: packet.getInt64(kStride * offset++, (int)Painting.FakeHostEndian) != 0,
                    pressure: packet.getFloat64(kStride * offset++, (int)Painting.FakeHostEndian),
                    pressureMin: packet.getFloat64(kStride * offset++, (int)Painting.FakeHostEndian),
                    pressureMax: packet.getFloat64(kStride * offset++, (int)Painting.FakeHostEndian),
                    distance: packet.getFloat64(kStride * offset++, (int)Painting.FakeHostEndian),
                    distanceMax: packet.getFloat64(kStride * offset++, (int)Painting.FakeHostEndian),
                    radiusMajor: packet.getFloat64(kStride * offset++, (int)Painting.FakeHostEndian),
                    radiusMinor: packet.getFloat64(kStride * offset++, (int)Painting.FakeHostEndian),
                    radiusMin: packet.getFloat64(kStride * offset++, (int)Painting.FakeHostEndian),
                    radiusMax: packet.getFloat64(kStride * offset++, (int)Painting.FakeHostEndian),
                    orientation: packet.getFloat64(kStride * offset++, (int)Painting.FakeHostEndian),
                    tilt: packet.getFloat64(kStride * offset++, (int)Painting.FakeHostEndian)
                );
            }

            return new PointerDataPacket(data: data);
        }
    }
}
