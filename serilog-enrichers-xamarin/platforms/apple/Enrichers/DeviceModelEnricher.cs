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

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(Constants.DeviceModelPropertyName,
                UIDevice.CurrentDevice.Model);
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }
    }
}