using App.Modules.Core.Substrate.tmp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Modules.Core.Substrate.tmp.Constants;

namespace App.Modules.Core.Shared.Models.TODO.ConfigurationSettings.CloudServices.Azure
{

    /// <summary>
    /// Configuration object to configure the Azure Redis Cache service.
    /// <para>
    /// TODO: Confirm Documentation
    /// </para>
    /// </summary>
    public class AzureRedisCacheConfigurationSettings
    {

        /// <summary>
        /// Gets or sets (from AppSettings)
        /// the ResourceName of this StorageAccount.
        /// <para>
        /// <para>
        /// If not provided in AppSettings, using
        /// <see cref="ConfigurationKeys.AppCoreIntegrationAzureStorageAccountDefaultResourceName"/>
        /// falls back to 
        /// <see cref="ConfigurationKeys.AppCoreIntegrationAzureCommonResourceName"/>
        /// plus 'di'.
        /// </para>
        /// </para>
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(ConfigurationKeys.AppCoreIntegrationAzureRedisCacheResourceName)]
        public string ResourceName
        {
            get; set;
        }

        /// <summary>
        /// The confidential authorisation Key required to access the remote service.
        /// <para>
        /// Requires Confidential Storage.
        /// </para>
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.KeyVault)]
        [Alias(ConfigurationKeys.AppCoreIntegrationAzureRedisCacheDefaultAuthorizationKey)]
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// Whether the service is enabled for use or not.
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(ConfigurationKeys.AppCoreIntegrationAzureRedisEnabled)]
        public string Enabled
        {
            get; set;
        }
    }
}
