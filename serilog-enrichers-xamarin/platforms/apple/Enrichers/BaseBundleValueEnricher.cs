using Foundation;
using Serilog.Core;
using Serilog.Events;

namespace Serilog.Enrichers
{
    /// <summary>
    /// Base class for enriching with values from IPA Main Bundle
    /// </summary>
    public abstract class BaseBundleValueEnricher : ILogEventEnricher
    {
        private readonly string _bundleKey;
        private readonly string _propertyName;

        private LogEventProperty _cachedProperty;

        /// <summary>
        /// Create bundle value enricher
        /// </summary>
        /// <param name="bundleKey">Key in the IPA Main Bundle</param>
        /// <param name="propertyName">Name of the property for the enrichment</param>
        public BaseBundleValueEnricher(string bundleKey, string propertyName)
        {
            _bundleKey = bundleKey;
            _propertyName = propertyName;
        }

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            _cachedProperty = _cachedProperty ??
                propertyFactory.CreateProperty(_propertyName, GetBundleValue(_bundleKey));
            logEvent.AddPropertyIfAbsent(_cachedProperty);
        }

        private string GetBundleValue(string key)
        {
            return NSBundle.MainBundle.ObjectForInfoDictionary(key)?.ToString();
        }
    }
}