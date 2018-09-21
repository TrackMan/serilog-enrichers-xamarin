using Serilog.Configuration;
using Serilog.Enrichers;
using System;

namespace Serilog
{
    /// <summary>
    /// Extens <see cref="LoggerConfiguration"/> to add enrichers for Android Device information.
    /// </summary>
    public static class LoggerConfigurationExtensions
    {
        /// <summary>
        /// Enrich log events with a AndroidDisplayMetrics property containing display metrics
        /// </summary>
        /// <param name="enrichment">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithDisplayMetrics(
            this LoggerEnrichmentConfiguration enrichment)
        {
            if (enrichment == null) throw new ArgumentNullException(nameof(enrichment));
            return enrichment.With<DeviceDisplayMetricsEnricher>();
        }

        /// <summary>
        /// Enrich log events with a AndroidFirmwareVersion property containing firmware version
        /// </summary>
        /// <param name="enrichment">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithFirmwareVersion(
            this LoggerEnrichmentConfiguration enrichment)
        {
            if (enrichment == null) throw new ArgumentNullException(nameof(enrichment));
            return enrichment.With<DeviceFirmwareVersionEnricher>();
        }

        /// <summary>
        /// Enrich log events with a AndroidHardwareVersion property containing hardware version
        /// </summary>
        /// <param name="enrichment">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithHardwareVersion(
            this LoggerEnrichmentConfiguration enrichment)
        {
            if (enrichment == null) throw new ArgumentNullException(nameof(enrichment));
            return enrichment.With<DeviceHardwareVersionEnricher>();
        }

        /// <summary>
        /// Enrich log events with a AndroidDeviceId property containing device id
        /// </summary>
        /// <param name="enrichment">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithDeviceId(
            this LoggerEnrichmentConfiguration enrichment)
        {
            if (enrichment == null) throw new ArgumentNullException(nameof(enrichment));
            return enrichment.With<DeviceIdEnricher>();
        }

        /// <summary>
        /// Enrich log events with a AndroidDeviceManufacturer property containing manufacturer name
        /// </summary>
        /// <param name="enrichment">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithManufacturerName(
            this LoggerEnrichmentConfiguration enrichment)
        {
            if (enrichment == null) throw new ArgumentNullException(nameof(enrichment));
            return enrichment.With<DeviceManufacturerEnricher>();
        }

        /// <summary>
        /// Enrich log events with a AndroidDeviceName property containing device name
        /// </summary>
        /// <param name="enrichment">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithDeviceName(
            this LoggerEnrichmentConfiguration enrichment)
        {
            if (enrichment == null) throw new ArgumentNullException(nameof(enrichment));
            return enrichment.With<DeviceNameEnricher>();
        }

        /// <summary>
        /// Enrich log events with a AndroidDeviceOrientation property containing device orientation
        /// </summary>
        /// <param name="enrichment">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithDeviceOrientation(
            this LoggerEnrichmentConfiguration enrichment)
        {
            if (enrichment == null) throw new ArgumentNullException(nameof(enrichment));
            return enrichment.With<DeviceOrientationEnricher>();
        }
    }
}
