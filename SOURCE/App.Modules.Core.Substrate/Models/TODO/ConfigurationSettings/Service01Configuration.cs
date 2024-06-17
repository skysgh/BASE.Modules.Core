namespace App.Modules.TmpSys.Shared.Models.TODO.ConfigurationSettings
{
    using App.Modules.TmpSys.Substrate.tmp.Attributes;
    using App.Modules.TmpSys.Substrate.tmp.Constants;

    /// <summary>
    /// An example of a remote Service Configuration package.
    /// </summary>
    public class Service01Configuration : IHostSettingsBasedConfigurationObject
    {

        /// <summary>
        /// The account key.
        /// <para>
        /// Make sure this kind of secrets are not gotten from AppSettings.
        /// </para>
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.KeyVault)]
        [Alias(ConfigurationKeys.AppCoreIntegrationService01ClientId)]
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// The account secret.
        /// <para>
        /// Make sure this kind of secrets are not gotten from AppSettings.
        /// </para>
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.KeyVault)]
        [Alias(ConfigurationKeys.AppCoreIntegrationService01ClientSecret)]
        public string Secret
        {
            get; set;
        }


        /// <summary>
        /// Base Uri of the service.
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSettingsViaDeploymentPipeline)]
        [Alias(ConfigurationKeys.AppCoreIntegrationService01BaseUri)]
        public string? BaseUri
        {
            get; set;
        }


        /// <summary>
        /// Misc config, Handler expected to know how to use.
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSettingsViaDeploymentPipeline)]
        [Alias(ConfigurationKeys.AppCoreIntegrationService01MiscConfig)]
        public string MiscConfig
        {
            get; set;
        }

    }
}