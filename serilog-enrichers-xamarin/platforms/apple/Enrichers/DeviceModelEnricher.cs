using Serilog.Core;
using Serilog.Events;
using UIKit;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with Apple Device Model
    /// </summary>
    public class DeviceModelEnricher : ILogEventEnricher
    {
        LogEventProperty _cachedProperty;

        public const string AppleDeviceModelPropertyName = "AppleDeviceModel";

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(AppleDeviceModelPropertyName,
                UIDevice.CurrentDevice.Model);
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }
    }
}