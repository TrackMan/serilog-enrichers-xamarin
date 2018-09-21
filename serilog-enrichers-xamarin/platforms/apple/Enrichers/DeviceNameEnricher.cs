using Serilog.Core;
using Serilog.Events;
using UIKit;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with Apple Device Name
    /// </summary>
    public class DeviceNameEnricher : ILogEventEnricher
    {
        LogEventProperty _cachedProperty;

        public const string AppleDeviceIdPropertyName = "AppleDeviceName";

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(AppleDeviceIdPropertyName,
                UIDevice.CurrentDevice.Name);
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }
    }
}