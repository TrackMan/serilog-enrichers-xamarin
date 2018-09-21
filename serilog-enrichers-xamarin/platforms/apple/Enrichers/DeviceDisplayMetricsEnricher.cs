using Serilog.Core;
using Serilog.Events;
using UIKit;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with Apple Device Display Metrics
    /// </summary>
    public class DeviceDisplayMetricsEnricher : ILogEventEnricher
    {
        LogEventProperty _cachedProperty;

        public const string AppleDeviceDisplayMetricsPropertyName = "AppleDeviceDisplayMetrics";

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(AppleDeviceDisplayMetricsPropertyName,
                UIDevice.CurrentDevice.Model);
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }

        private static string GetDisplayMetrics()
        {
            int height = (int)UIScreen.MainScreen.Bounds.Height;
            int width = (int)UIScreen.MainScreen.Bounds.Width;
            double xDpi = UIScreen.MainScreen.Scale * 160.0;
            double yDpi = UIScreen.MainScreen.Scale * 160.0;
            double scale = UIScreen.MainScreen.Scale;

            return $"Height: {height}, Width: {width}, Xdpi: {xDpi}, Ydpi: {yDpi}, Scale: {scale}";
        }
    }
}