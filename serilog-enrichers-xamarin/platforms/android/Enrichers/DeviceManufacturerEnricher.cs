using Android.OS;
using Serilog.Core;
using Serilog.Events;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with Android Device Manifacturer
    /// </summary>
    public class DeviceManufacturerEnricher : ILogEventEnricher
    {
        LogEventProperty _cachedProperty;

        public const string AndroidManufacturerPropertyName = "AndroidDeviceManufacturer";

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(AndroidManufacturerPropertyName, Build.Manufacturer);
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }
    }
}
