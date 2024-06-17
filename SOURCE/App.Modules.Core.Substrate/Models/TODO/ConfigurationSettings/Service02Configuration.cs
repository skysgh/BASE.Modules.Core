

// namespace App.Modules.TmpSys.Substrate.tmp.Models.Configuration.AppHost
// {
//     using App.Modules.TmpSys.Substrate.tmp.Attributes;
//     using App.Modules.TmpSys.Substrate.tmp.Models.ConfigurationSettings;

//     public class Service02Configuration: IHostSettingsBasedConfigurationObject
//     {

//         // Make sure this kind of secrets are not gotten from AppSettings.
//         [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.KeyVault)]
//         [Alias(ConfigurationKeys.AppCoreIntegrationService02ClientId)]
//         public string Key
//         {
//             get; set;
//         }

//         // Make sure this kind of secrets are not gotten from AppSettings.
//         [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.KeyVault)]
//         [Alias(ConfigurationKeys.AppCoreIntegrationService02ClientSecret)]
//         public string Secret
//         {
//             get; set;
//         }


//         [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSettingsViaDeploymentPipeline)]
//         [Alias(ConfigurationKeys.AppCoreIntegrationService02BaseUri)]
//         public string BaseUri
//         {
//             get; set;
//         }


//         [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSettingsViaDeploymentPipeline)]
//         [Alias(ConfigurationKeys.AppCoreIntegrationService02MiscConfig)]
//         public string MiscConfig
//         {
//             get; set;
//         }

//     }
// }