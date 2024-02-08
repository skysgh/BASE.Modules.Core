namespace App.Modules.Core.Shared.Models.TODO.ConfigurationSettings.CloudServices.Azure
{
    using App.Base.Shared.Attributes;
    using App.Base.Shared.Constants;
    using App.Modules.Core.Shared.Models.TODO.ConfigurationSettings;

    /// <summary>
    /// A 
    /// </summary>
    public class AzureEnvironmentSettings : IHostSettingsBasedConfigurationObject, IKeyVaultBasedConfigurationObject
    {

        /// <summary>
        /// TODO: Improve Documentation
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(ConfigurationKeys.AppCoreEnvironmentSubscriptionId)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// TODO: Improve Documentation
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(ConfigurationKeys.AppCoreEnvironmentTenantId)]
        public string TenantId { get; set; }

        /// <summary>
        /// TODO: Improve Documentation
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(ConfigurationKeys.AppCoreEnvironmentResourceGroupName)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// TODO: Improve Documentation
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(ConfigurationKeys.AppCoreEnvironmentResourceGroupLocation)]
        public string ResourceGroupLocation { get; set; }
    }

}
