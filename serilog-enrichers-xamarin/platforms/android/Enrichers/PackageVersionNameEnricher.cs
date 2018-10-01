using Android.App;
using Serilog.Core;
using Serilog.Events;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with the Package Version Name of the Android App
    /// </summary>
    public class PackageVersionNameEnricher : ILogEventEnricher
    {
        LogEventProperty _cachedProperty;

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(Constants.PackageVersionNamePropertyName, GetPackageVersionName());
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }

        private string GetPackageVersionName()
        {
            var packageInfo = Application.Context.PackageManager.GetPackageInfo(Application.Context.PackageName, 0);
            return packageInfo.VersionName;
        }
    }
}
