using CustomSettingManagement.Localization;
using CustomSettingManagement.SystemScheduler;
using CustomSettingManagement.Web.Pages.SettingManagement.Components.SystemSchedulerGroup;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;
using Volo.Abp.SettingManagement.Web.Pages.SettingManagement;

namespace CustomSettingManagement.Web.Settings;

public class SystemSchedulerContributor : SettingPageContributorBase
{
    public SystemSchedulerContributor()
    {
        RequiredPermissions(SystemSchedulerPermissions.SystemScheduler.EditSchedulerPollingInterval);
    }

    public override Task ConfigureAsync(SettingPageCreationContext context)
    {
        IStringLocalizer<CustomSettingManagementResource> l = context.ServiceProvider.GetRequiredService<IStringLocalizer<CustomSettingManagementResource>>();
        var group = new SettingPageGroup(
                SystemSchedulerPermissions.SystemScheduler.GroupName,
                l["Menu:SystemScheduler"],
                typeof(SystemSchedulerViewComponent)
            );
        context.Groups.Add(group);

        return Task.CompletedTask;
    }
}
