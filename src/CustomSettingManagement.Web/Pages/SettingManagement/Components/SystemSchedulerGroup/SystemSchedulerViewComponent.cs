using CustomSettingManagement.SystemScheduler;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.SettingManagement;
using Volo.Abp.SettingManagement.Web;
using static Volo.Abp.SettingManagement.Web.Pages.SettingManagement.Components.EmailSettingGroup.EmailSettingGroupViewComponent;

namespace CustomSettingManagement.Web.Pages.SettingManagement.Components.SystemSchedulerGroup
{
    public class SystemSchedulerViewComponent : AbpViewComponent
    {
        private readonly ISystemSchedulerAppService systemSchedulerAppService;

        public SystemSchedulerViewComponent(ISystemSchedulerAppService systemSchedulerAppService)
        {
            this.systemSchedulerAppService = systemSchedulerAppService;
        }

        public virtual async Task<IViewComponentResult> InvokeAsync()
        {
            var settings = await systemSchedulerAppService.GetAsync();
            var model = ObjectMapper.Map<SystemSchedulerSettingsDto, SystemSchedulerViewComponent.ViewModel>(settings);
            return View("~/Pages/SettingManagement/Components/SystemSchedulerGroup/Default.cshtml", model);
        }

        public class ViewModel
        {
            [Range(1, 60)]
            [Display(Name = "Label:SystemSchedulerSetting.PollingInterval")]
            [Description("Description:SystemSchedulerSetting.PollingInterval")]
            public int SchedulerPollingIntervalMins { get; set; }
        }
    }
}
