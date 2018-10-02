using Android.App;
using Serilog.Core;
using Serilog.Events;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with the Package Name of the Android App
    /// </summary>
    public class PackageNameEnricher : ILogEventEnricher
    {
        LogEventProperty _cachedProperty;

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(Constants.PackageNamePropertyName, GetPackageName());
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }

        private string GetPackageName()
        {
            return Application.Context.PackageName;
        }
    }
}
