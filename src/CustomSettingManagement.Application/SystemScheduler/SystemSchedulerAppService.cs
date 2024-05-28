using CustomSettingManagement.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.MultiTenancy;
using Volo.Abp.SettingManagement;
using Volo.Abp.Timing;
namespace CustomSettingManagement.SystemScheduler;


[Authorize(SystemSchedulerPermissions.SystemScheduler.GroupName)]
public class SystemSchedulerAppService : CustomSettingManagementAppService, ISystemSchedulerAppService
{
    private readonly ISettingManager settingManager;

    public SystemSchedulerAppService(ISettingManager settingManager)
    {
        this.settingManager = settingManager;
    }

    public async Task<SystemSchedulerSettingsDto> GetAsync() 
    {
        if (CurrentTenant.GetMultiTenancySide() == MultiTenancySides.Host)
        {
            var pollingInterval = await settingManager.GetOrNullGlobalAsync(SystemSchedulerSettingNames.PollingInterval);
            var result = new SystemSchedulerSettingsDto
            {
                SchedulerPollingIntervalMins = Convert.ToInt32(pollingInterval)
            };

            return result;
        }

        var tenantResult = new SystemSchedulerSettingsDto
        {
            SchedulerPollingIntervalMins = Convert.ToInt32(await settingManager.GetOrNullForCurrentTenantAsync(SystemSchedulerSettingNames.PollingInterval))
        };

        return tenantResult;
    }

    [Authorize(SystemSchedulerPermissions.SystemScheduler.EditSchedulerPollingInterval)]
    public async Task UpdateAsync(UpdateSystemSchedulerSettingsDto input)
    {
        if (CurrentTenant.GetMultiTenancySide() == MultiTenancySides.Host)
        {
            await settingManager.SetGlobalAsync(SystemSchedulerSettingNames.PollingInterval, input.SchedulerPollingIntervalMins.ToString());
        }
        else
        {
            await settingManager.SetForCurrentTenantAsync(SystemSchedulerSettingNames.PollingInterval, input.SchedulerPollingIntervalMins.ToString());
        }
    }
}
