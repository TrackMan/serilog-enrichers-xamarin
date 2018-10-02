using Android.App;
using Serilog.Core;
using Serilog.Events;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with the Package Version Code of the Android App
    /// </summary>
    public class PackageVersionCodeEnricher : ILogEventEnricher
    {
        LogEventProperty _cachedProperty;

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(Constants.PackageVersionCodePropertyName, GetPackageVersionCode());
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }

        private int GetPackageVersionCode()
        {
            var packageInfo = Application.Context.PackageManager.GetPackageInfo(Application.Context.PackageName, 0);
            return packageInfo.VersionCode;
        }
    }
}
