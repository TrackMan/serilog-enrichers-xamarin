using Android.App;
using Android.OS;
using Serilog.Core;
using Serilog.Events;
using System;
using AndroidSettings = Android.Provider.Settings;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with Android Device ID
    /// </summary>
    public class DeviceIdEnricher : ILogEventEnricher
    {
        LogEventProperty _cachedProperty;

        public const string AndroidDeviceIdPropertyName = "AndroidDeviceId";
        
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ?? 
                propertyFactory.CreateProperty(AndroidDeviceIdPropertyName, GetAndroidDeviceId());
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }

        private static string GetAndroidDeviceId()
        {
            var serial = "";
            try
            { // Android 2.3 and up (API 10)
                serial = Build.Serial;
            }
            catch (Exception) { /* ignored */ }

            var androidId = "";
            try
            { // Not 100% reliable on 2.2 (API 8)
                androidId = AndroidSettings.Secure.GetString(
                    Application.Context.ContentResolver,
                    AndroidSettings.Secure.AndroidId);
            }
            catch (Exception) { /* ignored */ }

            return serial + androidId;
        }
    }
}