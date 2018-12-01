using FlutterBinding.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using FlutterBinding.Flow.Layers;
using FlutterBinding.Mapping;
using FlutterBinding.Shell;
using Newtonsoft.Json;
using static FlutterBinding.Mapping.Helper;
using static FlutterBinding.Mapping.Types;


namespace FlutterBinding.Engine.Window
{
    // NOTE: What is in this file is mostly from the C++ Engine side of Window

    public class NativeWindow
    {
        protected WindowClient client_ { get; set; }

        //private DartPersistentValue library_;
        private ViewportMetrics viewport_metrics_;

        public ViewportMetrics viewport_metrics() { return viewport_metrics_; }

        // TODO: Not required
        void DidCreateIsolate() { }

        private UI.Window window => UI.Window.Instance;

        public void UpdateWindowMetrics(ViewportMetrics metrics)
        {
            viewport_metrics_ = metrics;

            // This bypasses Hooks.cs
            window.devicePixelRatio = metrics.device_pixel_ratio;
            window.physicalSize     = new Size(metrics.physical_width, metrics.physical_height);
            window.padding = new WindowPadding(
                left: metrics.physical_padding_left,
                top: metrics.physical_padding_top,
                right: metrics.physical_padding_right,
                bottom: metrics.physical_padding_bottom
                );
            window.viewInsets = new WindowPadding(
                left: metrics.physical_view_inset_left,
                top: metrics.physical_view_inset_top,
                right: metrics.physical_view_inset_right,
                bottom: metrics.physical_view_inset_bottom);

            _invoke(window.onMetricsChanged, window.OnMetricsChangedZone);
        }

        public void UpdateLocales(List<string> locales)
        {
            const int stringsPerLocale = 4;
            int numLocales = (int)Math.Truncate((double)locales.Count / stringsPerLocale);

            window.locales = new List<Locale>(numLocales);
            for (int localeIndex = 0; localeIndex < numLocales; localeIndex++)
            {
                window.locales[localeIndex] = new Locale(
                    locales[localeIndex * stringsPerLocale],
                    locales[localeIndex * stringsPerLocale + 1]);
            }
            _invoke(window.onLocaleChanged, window.OnLocaleChangedZone);
        }

        public void UpdateUserSettingsData(string jsonData)
        {
            var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonData);

            window.textScaleFactor = Convert.ToDouble(data["textScaleFactor"]);
            window.alwaysUse24HourFormat = Convert.ToBoolean(data["alwaysUse24HourFormat"]);

            _invoke(window.onTextScaleFactorChanged, window.OnTextScaleFactorChangedZone);
        }

        public void UpdateSemanticsEnabled(bool enabled)
        {
            window.semanticsEnabled = enabled;
            _invoke(window.onSemanticsEnabledChanged, window.OnSemanticsEnabledChangedZone);
        }

        public void UpdateAccessibilityFeatures(AccessibilityFeatures newFeatures)
        {
            if (newFeatures == window.accessibilityFeatures)
                return;
            window.accessibilityFeatures = newFeatures;
            _invoke(window.onAccessibilityFeaturesChanged, window.OnAccessibilityFlagsChangedZone);
        }

        //public void DispatchPlatformMessage(PlatformMessage message)
        //{
        //    if (window.onPlatformMessage == null)
        //        return;
        //    _invoke(() => window.onPlatformMessage(message), window.OnPlatformMessageZone);
        //}

        public void DispatchPointerDataPacket(PointerDataPacket packet)
        {
            if (window.onPointerDataPacket == null)
                return;
            _invoke(
                () => window.onPointerDataPacket(packet), 
                window.OnPointerDataPacketZone);
        }

        public void DispatchSemanticsAction(int id, SemanticsAction action, object args)
        {
            if (window.onSemanticsAction == null)
                return;

            _invoke(
                () => { window.onSemanticsAction(id, action, args); }, 
                window.OnSemanticsActionZone);
        }

        public void BeginFrame(TimePoint frameTime)
        {
            var now = TimePoint.Now();
            var diff = now.TotalMicroseconds - frameTime.TotalMicroseconds;

            _invoke(
                () => window.onBeginFrame(new Duration(microseconds:diff)), 
                window.OnBeginFrameZone);
        }

        //public void CompletePlatformMessageResponse(int response_id, std::vector<uint8_t> data);
        //public void CompletePlatformMessageEmptyResponse(int response_id);

        // 
        //public static void RegisterNatives(tonic::DartLibraryNatives* natives);

        public void Render(Scene scene)
        {
            Engine.Instance.Render(scene.TakeLayerTree());
        }


        //protected void SendPlatformMessage(string name,
        //                                   object data = null,
        //                                   PlatformMessageResponse response = null)
        //{
        //    response = response ?? new PlatformMessageResponse();
        //    client_.HandlePlatformMessage(new PlatformMessage(name, data, response ));
        //}

        /// Invokes [callback] inside the given [zone].
        static void _invoke(VoidCallback callback, Zone zone)
        {
            if (callback == null)
                return;
            if (Zone.current == zone)
                callback();
            else
                zone.runGuarded(callback);
        }


        // TODO: This is a poor way of doing request/response management
        // We use id 0 to mean that no response is expected.
        //private int next_response_id_ = 1;
        //private Dictionary<int, PlatformMessageResponse> pending_responses_ = new Dictionary<int,PlatformMessageResponse>();
    }
}
