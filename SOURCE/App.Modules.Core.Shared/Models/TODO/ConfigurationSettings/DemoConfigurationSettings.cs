namespace App.Modules.Core.Shared.Models.TODO.ConfigurationSettings
{
    using App.Base.Shared.Attributes;
    using App.Base.Shared.Constants;

    /// <summary>
    /// TODO: Better documentation
    /// </summary>
    public class DemoConfigurationSettings : IHostSettingsBasedConfigurationObject
    {
        /// <summary>
        /// TODO: Better documentation
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(ConfigurationKeys.AppCoreDemoMode)]
        public bool DemoMode
        {
            get; set;
        }
    }
}
