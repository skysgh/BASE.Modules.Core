﻿

// namespace App.Base.Shared.Models.Configuration.AppHost
// {
//     using App.Base.Shared.Attributes;
//     using App.Base.Shared.Models.ConfigurationSettings;

//     public class Service03Configuration: IHostSettingsBasedConfigurationObject
//     {

//         // Make sure this kind of secrets are not gotten from AppSettings.
//         [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.KeyVault)]
//         [Alias(Constants.ConfigurationKeys.AppCoreIntegrationService03ClientId)]
//         public string Key
//         {
//             get; set;
//         }

//         // Make sure this kind of secrets are not gotten from AppSettings.
//         [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.KeyVault)]
//         [Alias(Constants.ConfigurationKeys.AppCoreIntegrationService03ClientSecret)]
//         public string Secret
//         {
//             get; set;
//         }


//         [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSettingsViaDeploymentPipeline)]
//         [Alias(Constants.ConfigurationKeys.AppCoreIntegrationService03BaseUri)]
//         public string BaseUri
//         {
//             get; set;
//         }


//         [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSettingsViaDeploymentPipeline)]
//         [Alias(Constants.ConfigurationKeys.AppCoreIntegrationService03MiscConfig)]
//         public string MiscConfig
//         {
//             get; set;
//         }

//     }
// }