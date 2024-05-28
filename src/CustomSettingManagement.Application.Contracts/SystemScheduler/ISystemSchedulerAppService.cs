using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace CustomSettingManagement.SystemScheduler;

public interface ISystemSchedulerAppService : IApplicationService
{
    Task<SystemSchedulerSettingsDto> GetAsync();
    Task UpdateAsync(UpdateSystemSchedulerSettingsDto input);
}
