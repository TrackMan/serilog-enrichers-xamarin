using Android.App;
using Android.Runtime;
using Android.Views;
using Serilog.Core;
using Serilog.Events;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with Android Device Orientation
    /// </summary>
    public class DeviceOrientationEnricher : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            var property = propertyFactory.CreateProperty(
                Constants.DeviceOrientationPropertyName, GetDeviceOrientation());
            logEvent.AddPropertyIfAbsent(property);
        }

        private static string GetDeviceOrientation()
        {
            var windowManager = Application.Context.GetSystemService(Android.Content.Context.WindowService)
                .JavaCast<IWindowManager>();

            switch(windowManager.DefaultDisplay.Rotation)
            {
                case SurfaceOrientation.Rotation0:
                    return "PortraitUp";
                case SurfaceOrientation.Rotation180:
                    return "PortraitDown";
                case SurfaceOrientation.Rotation90:
                    return "LandscapeLeft";
                case SurfaceOrientation.Rotation270:
                    return "LandscareRight";
            }

            return "None";
        }
    }
}
