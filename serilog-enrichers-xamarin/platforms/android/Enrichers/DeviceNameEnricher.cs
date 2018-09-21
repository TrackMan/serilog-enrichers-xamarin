using Android.OS;
using Serilog.Core;
using Serilog.Events;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with Android Device Name
    /// </summary>
    public class DeviceNameEnricher : ILogEventEnricher
    {
        LogEventProperty _cachedProperty;

        public const string AndroidDeviceNamePropertyName = "AndroidDeviceName";

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(AndroidDeviceNamePropertyName, Build.Model);
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }
    }
}
