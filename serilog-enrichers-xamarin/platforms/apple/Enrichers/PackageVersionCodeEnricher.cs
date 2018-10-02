namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with Apple IPA Bundle Version
    /// </summary>
    public class PackageVersionCodeEnricher : BaseBundleValueEnricher
    {
        public PackageVersionCodeEnricher()
            : base("CFBundleVersion", Constants.PackageVersionCodePropertyName) { }
    }
}