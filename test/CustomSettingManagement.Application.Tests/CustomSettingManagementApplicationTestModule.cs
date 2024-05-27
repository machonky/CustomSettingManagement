using Volo.Abp.Modularity;

namespace CustomSettingManagement;

[DependsOn(
    typeof(CustomSettingManagementApplicationModule),
    typeof(CustomSettingManagementDomainTestModule)
)]
public class CustomSettingManagementApplicationTestModule : AbpModule
{

}
