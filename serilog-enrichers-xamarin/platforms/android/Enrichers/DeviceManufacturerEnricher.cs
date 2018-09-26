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

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(Constants.DeviceManufacturerPropertyName, 
                Build.Manufacturer);
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }
    }
}
