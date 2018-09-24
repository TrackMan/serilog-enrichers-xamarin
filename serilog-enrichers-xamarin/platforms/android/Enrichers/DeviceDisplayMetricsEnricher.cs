using Android.App;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Serilog.Core;
using Serilog.Events;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with Android Device Display Metrics
    /// </summary>
    public class DeviceDisplayMetricsEnricher : ILogEventEnricher
    {
        LogEventProperty _cachedProperty;


        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(Constants.DisplayMetricsPropertyName, GetDisplayMetrics());
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }

        private static string GetDisplayMetrics()
        {
            var windowManager = Application.Context.GetSystemService(Android.Content.Context.WindowService)
                .JavaCast<IWindowManager>();

            var metrics = new DisplayMetrics();
            windowManager.DefaultDisplay.GetMetrics(metrics);

            return $"Height: {metrics.HeightPixels} px, Width: {metrics.WidthPixels} px, Xdpi: {metrics.Xdpi}, Ydpi: {metrics.Ydpi}, Scale: {metrics.DensityDpi} dpi";
        }
    }
}
