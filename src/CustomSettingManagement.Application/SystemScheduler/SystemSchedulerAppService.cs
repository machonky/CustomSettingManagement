using CustomSettingManagement.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.MultiTenancy;
using Volo.Abp.SettingManagement;
using Volo.Abp.Timing;
namespace CustomSettingManagement.SystemScheduler;

[RemoteService(false)]
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
        var tenantResult = new SystemSchedulerSettingsDto
        {
            SchedulerPollingIntervalMins = Convert.ToInt32(await settingManager.GetOrNullGlobalAsync(SystemSchedulerSettingNames.PollingInterval)),
            BusinessDaysLookahead = Convert.ToInt32(await settingManager.GetOrNullForCurrentTenantAsync(SystemSchedulerSettingNames.BusinessDaysLookahead))
        };

        return tenantResult;
    }

    [Authorize(SystemSchedulerPermissions.SystemScheduler.EditPollingInterval)]
    public async Task UpdateAsync(UpdateSystemSchedulerSettingsDto input)
    {
        if (CurrentTenant.GetMultiTenancySide() == MultiTenancySides.Host)
        {
            await settingManager.SetGlobalAsync(SystemSchedulerSettingNames.PollingInterval, input.SchedulerPollingIntervalMins.ToString());
        }
 
        await settingManager.SetForCurrentTenantAsync(SystemSchedulerSettingNames.BusinessDaysLookahead, input.BusinessDaysLookahead.ToString());
    }
}
