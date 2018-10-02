namespace Serilog.Enrichers
{
    /// <summary>
    /// Enriches log events with Apple IPA Bundle Short Version
    /// </summary>
    public class PackageVersionNameEnricher : BaseBundleValueEnricher
    {
        public PackageVersionNameEnricher()
            : base("CFBundleShortVersionString", Constants.PackageVersionNamePropertyName) { }
    }
}