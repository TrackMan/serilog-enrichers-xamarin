using Android.OS;
using Serilog.Core;
using Serilog.Events;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with Android Hardware Version
    /// </summary>
    public class DeviceHardwareVersionEnricher : ILogEventEnricher
    {
        LogEventProperty _cachedProperty;

        public const string AndroidHardwareVersionPropertyName = "AndroidHardwareVersion";

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(AndroidHardwareVersionPropertyName, Build.Hardware);
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }
    }
}
