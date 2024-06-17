using App.Modules.TmpSys.Substrate.tmp.Models.Configuration;

namespace App.Modules.TmpSys.Shared.Models.TODO.ConfigurationSettings
{
    /// <summary>
    /// Contract for objects that will be passed through the 
    /// KeyVault based Config Factory
    /// </summary>
    public interface IKeyVaultBasedConfigurationObject : IConfigurationObject
    {
    }
}
