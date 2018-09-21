using Android.OS;
using Serilog.Core;
using Serilog.Events;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with Android Firmware Version
    /// </summary>
    public class DeviceFirmwareVersionEnricher : ILogEventEnricher
    {
        LogEventProperty _cachedProperty;

        public const string AndroidFirmwareVersionPropertyName = "AndroidFirmwareVersion";

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(AndroidFirmwareVersionPropertyName, Build.VERSION.Release);
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }
    }
}
