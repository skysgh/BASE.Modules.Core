namespace App.Modules.Core.Shared.Models.TODO.ConfigurationSettings
{
    using App.Modules.Core.Substrate.tmp.Attributes;
    using App.Modules.Core.Substrate.tmp.Constants;

    /// <summary>
    /// An immutable host configuration object 
    /// describing the configuration of the 
    /// Application Insights service.
    /// </summary>
    public class ApplicationInsightsConfigurationSettings : IKeyVaultBasedConfigurationObject
    {

        /// <summary>
        /// The unique string key to identify app in Insights.
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.KeyVault)]
        [Alias(ConfigurationKeys.AppCoreIntegrationAzureApplicationInsightsInstrumentationKey)]
        public string Key { get; set; }

        /// <summary>
        /// Get/Set whether to use the service.
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(ConfigurationKeys.AppCoreIntegrationAzureApplicationInsightsInstrumentationKeyEnabled)]
        public bool Enabled { get; set; }
    }
}
