using Serilog.Core;
using Serilog.Events;
using UIKit;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with Apple Device System Version
    /// </summary>
    public class DeviceSystemVersionEnricher : ILogEventEnricher
    {
        LogEventProperty _cachedProperty;

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(Constants.DeviceSystemVersionPropertyName,
                UIDevice.CurrentDevice.SystemVersion);
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }
    }
}