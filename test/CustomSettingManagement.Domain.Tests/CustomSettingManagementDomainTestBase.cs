using Volo.Abp.Modularity;

namespace CustomSettingManagement;

/* Inherit from this class for your domain layer tests. */
public abstract class CustomSettingManagementDomainTestBase<TStartupModule> : CustomSettingManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
