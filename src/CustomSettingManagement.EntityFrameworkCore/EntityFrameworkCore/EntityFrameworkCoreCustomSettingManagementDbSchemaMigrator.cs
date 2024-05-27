using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CustomSettingManagement.Data;
using Volo.Abp.DependencyInjection;

namespace CustomSettingManagement.EntityFrameworkCore;

public class EntityFrameworkCoreCustomSettingManagementDbSchemaMigrator
    : ICustomSettingManagementDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCustomSettingManagementDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the CustomSettingManagementDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CustomSettingManagementDbContext>()
            .Database
            .MigrateAsync();
    }
}
