namespace App.Modules.Core.Shared.Models.TODO.ConfigurationSettings
{
    using App.Base.Shared.Attributes;
    using App.Base.Shared.Constants;
    using App.Base.Shared.Models.Configuration;

    /// <summary>
    /// A Configuration settings package to use when configuring Media Management
    /// </summary>
    public class MediaManagementConfigurationSettings : IHostSettingsBasedConfigurationObject
    {
        private string? _hashType;

        /// <summary>
        /// THe Hash type to use when making the hash
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(ConfigurationKeys.AppCoreMediaHashType)]
        public string HashType
        {
            get { return _hashType ?? "SHA-256"; }
            set { _hashType = value; }
        }
    }
}