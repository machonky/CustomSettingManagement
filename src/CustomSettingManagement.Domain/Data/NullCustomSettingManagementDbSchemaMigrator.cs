using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CustomSettingManagement.Data;

/* This is used if database provider does't define
 * ICustomSettingManagementDbSchemaMigrator implementation.
 */
public class NullCustomSettingManagementDbSchemaMigrator : ICustomSettingManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
