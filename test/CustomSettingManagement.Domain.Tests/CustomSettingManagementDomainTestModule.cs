using Volo.Abp.Modularity;

namespace CustomSettingManagement;

[DependsOn(
    typeof(CustomSettingManagementDomainModule),
    typeof(CustomSettingManagementTestBaseModule)
)]
public class CustomSettingManagementDomainTestModule : AbpModule
{

}
