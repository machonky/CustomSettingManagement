using CustomSettingManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CustomSettingManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CustomSettingManagementEntityFrameworkCoreModule),
    typeof(CustomSettingManagementApplicationContractsModule)
    )]
public class CustomSettingManagementDbMigratorModule : AbpModule
{
}
