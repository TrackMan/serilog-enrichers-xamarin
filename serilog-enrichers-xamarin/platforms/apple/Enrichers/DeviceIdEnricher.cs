using Serilog.Core;
using Serilog.Events;
using UIKit;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with Apple Device ID
    /// </summary>
    public class DeviceIdEnricher : ILogEventEnricher
    {
        LogEventProperty _cachedProperty;

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(Constants.DeviceIdPropertyName, 
                UIDevice.CurrentDevice.IdentifierForVendor.AsString());
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }
    }
}