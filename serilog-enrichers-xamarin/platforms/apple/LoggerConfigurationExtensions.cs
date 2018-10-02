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
        /// Enrich log events with a AppleDisplayMetrics property containing display metrics
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
        /// Enrich log events with a AppleDeviceSystemVersion property containing firmware version
        /// </summary>
        /// <param name="enrichment">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithSystemVersion(
            this LoggerEnrichmentConfiguration enrichment)
        {
            if (enrichment == null) throw new ArgumentNullException(nameof(enrichment));
            return enrichment.With<DeviceSystemVersionEnricher>();
        }

        /// <summary>
        /// Enrich log events with a AppleDeviceModel property containing hardware version
        /// </summary>
        /// <param name="enrichment">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithDeviceModel(
            this LoggerEnrichmentConfiguration enrichment)
        {
            if (enrichment == null) throw new ArgumentNullException(nameof(enrichment));
            return enrichment.With<DeviceModelEnricher>();
        }

        /// <summary>
        /// Enrich log events with a AppleDeviceId property containing device id
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
        /// Enrich log events with IPA Bundle Identifier
        /// </summary>
        /// <param name="enrichment">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithPackageName(
            this LoggerEnrichmentConfiguration enrichment)
        {
            if (enrichment == null) throw new ArgumentNullException(nameof(enrichment));
            return enrichment.With<PackageNameEnricher>();
        }

        /// <summary>
        /// Enrich log events with IPA Bundle Version
        /// </summary>
        /// <param name="enrichment">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithPackageVersionName(
            this LoggerEnrichmentConfiguration enrichment)
        {
            if (enrichment == null) throw new ArgumentNullException(nameof(enrichment));
            return enrichment.With<PackageVersionNameEnricher>();
        }

        /// <summary>
        /// Enrich log events with IPA Bundle Short Version
        /// </summary>
        /// <param name="enrichment">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithPackageVersionCode(
            this LoggerEnrichmentConfiguration enrichment)
        {
            if (enrichment == null) throw new ArgumentNullException(nameof(enrichment));
            return enrichment.With<PackageVersionCodeEnricher>();
        }
    }
}
