using System;
using System.Collections.Generic;
using FlutterBinding.Mapping;
using FlutterBinding.Shell;
using FlutterBinding.UI;
using Newtonsoft.Json;

namespace FlutterBinding.Engine.Window
{
    // NOTE: What is in this file is mostly from the C++ Engine side of Window

    public class NativeWindow
    {
        protected IWindowClient _client { get; set; }

        //private DartPersistentValue library_;
        private ViewportMetrics _viewport_metrics;

        public ViewportMetrics viewport_metrics()
        {
            return _viewport_metrics;
        }

        // TODO: Not required
        void DidCreateIsolate() { }

        private UI.Window _window => UI.Window.Instance;

        public void UpdateWindowMetrics(ViewportMetrics metrics)
        {
            _viewport_metrics = metrics;

            // This bypasses Hooks.cs
            _window.devicePixelRatio = metrics.DevicePixelRatio;
            _window.physicalSize     = new Size(metrics.PhysicalWidth, metrics.PhysicalHeight);
            _window.padding = new WindowPadding(
                left: metrics.PhysicalPaddingLeft,
                top: metrics.PhysicalPaddingTop,
                right: metrics.PhysicalPaddingRight,
                bottom: metrics.PhysicalPaddingBottom
            );
            _window.viewInsets = new WindowPadding(
                left: metrics.PhysicalViewInsetLeft,
                top: metrics.PhysicalViewInsetTop,
                right: metrics.PhysicalViewInsetRight,
                bottom: metrics.PhysicalViewInsetBottom);

            _invoke(_window.onMetricsChanged, _window.OnMetricsChangedZone);
        }

        public void UpdateLocales(List<Locale> locales)
        {
            _window.locales = locales;
            _invoke(_window.onLocaleChanged, _window.OnLocaleChangedZone);
        }

        public void UpdateUserSettingsData(string jsonData)
        {
            var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonData);

            _window.textScaleFactor       = Convert.ToDouble(data["textScaleFactor"]);
            _window.alwaysUse24HourFormat = Convert.ToBoolean(data["alwaysUse24HourFormat"]);

            _invoke(_window.OnTextScaleFactorChanged, _window.OnTextScaleFactorChangedZone);
        }

        public void UpdateSemanticsEnabled(bool enabled)
        {
            _window.semanticsEnabled = enabled;
            _invoke(_window.onSemanticsEnabledChanged, _window.OnSemanticsEnabledChangedZone);
        }

        public void UpdateAccessibilityFeatures(AccessibilityFeatures newFeatures)
        {
            if (newFeatures == _window.accessibilityFeatures)
                return;
            _window.accessibilityFeatures = newFeatures;
            _invoke(_window.onAccessibilityFeaturesChanged, _window.OnAccessibilityFlagsChangedZone);
        }

        public void DispatchPlatformMessage(PlatformMessage message)
        {
            if (_window.OnPlatformMessage == null)
                return;
            _invoke(() => _window.OnPlatformMessage(message), _window.OnPlatformMessageZone);
        }

        public void DispatchPointerDataPacket(PointerDataPacket packet)
        {
            if (_window.onPointerDataPacket == null)
                return;
            _invoke(
                () => _window.onPointerDataPacket(packet),
                _window.OnPointerDataPacketZone);
        }

        public void DispatchSemanticsAction(int id, SemanticsAction action, object args)
        {
            if (_window.onSemanticsAction == null)
                return;

            _invoke(
                () => { _window.onSemanticsAction(id, action, args); },
                _window.OnSemanticsActionZone);
        }

        public void BeginFrame(TimePoint frameTime)
        {
            var now = TimePoint.Now();
            var diff = now.TotalMicroseconds - frameTime.TotalMicroseconds;

            _invoke(
                () => _window.onBeginFrame(TimeDelta.FromMicroseconds(diff)),
                _window.OnBeginFrameZone);
        }

        //public void CompletePlatformMessageResponse(int response_id, std::vector<uint8_t> data);
        //public void CompletePlatformMessageEmptyResponse(int response_id);

        // 
        //public static void RegisterNatives(tonic::DartLibraryNatives* natives);

        public void Render(Scene scene)
        {
            Engine.Instance.Render(scene.TakeLayerTree());
        }

        protected void SendPlatformMessage(string name,
                                           object data = null,
                                           PlatformMessageResponseCallback onResponse = null)
        {
            var responseMessage = new PlatformMessageResponse(onResponse, null);
            var message = new PlatformMessage(name, data, responseMessage);
            _client.HandlePlatformMessage(message);
        }


        /// Invokes [callback] inside the given [zone].
        static void _invoke(VoidCallback callback, Types.Zone zone)
        {
            if (callback == null)
                return;
            if (Types.Zone.current == zone)
                callback();
            else
                zone.runGuarded(callback);
        }


        // We use id 0 to mean that no response is expected.
        //private int _nextResponseId = 1;
        //private Dictionary<int, PlatformMessageResponse> _pendingResponses_ = new Dictionary<int,PlatformMessageResponse>();
    }
}
