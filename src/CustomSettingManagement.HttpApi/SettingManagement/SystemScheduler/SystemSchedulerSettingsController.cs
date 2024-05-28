using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.SettingManagement;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using CustomSettingManagement.SystemScheduler;

namespace CustomSettingManagement.SettingManagement.SystemScheduler;

[RemoteService(Name = SettingManagementRemoteServiceConsts.RemoteServiceName)]
[Area(SettingManagementRemoteServiceConsts.ModuleName)]
[Route("api/setting-management/system-scheduler")]
public class SystemSchedulerSettingsController : AbpControllerBase, ISystemSchedulerAppService
{
    private readonly ISystemSchedulerAppService systemSchedulerAppService;

    public SystemSchedulerSettingsController(ISystemSchedulerAppService systemSchedulerAppService)
    {
        this.systemSchedulerAppService = systemSchedulerAppService;
    }

    [HttpGet]
    public async Task<SystemSchedulerSettingsDto> GetAsync()
    {
        return await systemSchedulerAppService.GetAsync();
    }

    [HttpPost]
    public async Task UpdateAsync(UpdateSystemSchedulerSettingsDto input)
    { 
        await systemSchedulerAppService.UpdateAsync(input);
    }
}
