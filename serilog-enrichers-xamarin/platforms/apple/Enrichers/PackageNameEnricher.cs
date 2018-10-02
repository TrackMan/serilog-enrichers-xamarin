namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with Apple IPA Bundle Identifier
    /// </summary>
    public class PackageNameEnricher : BaseBundleValueEnricher
    {
        public PackageNameEnricher() 
            : base("CFBundleIdentifier", Constants.PackageNamePropertyName) { }
    }
}