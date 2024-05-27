using Volo.Abp.Modularity;

namespace CustomSettingManagement;

public abstract class CustomSettingManagementApplicationTestBase<TStartupModule> : CustomSettingManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
