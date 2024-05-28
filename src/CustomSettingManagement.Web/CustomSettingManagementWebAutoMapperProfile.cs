using AutoMapper;
using Volo.Abp.SettingManagement.Web.Pages.SettingManagement.Components.EmailSettingGroup;
using Volo.Abp.SettingManagement;
using CustomSettingManagement.Web.Pages.SettingManagement.Components.SystemSchedulerGroup;
using CustomSettingManagement.SystemScheduler;

namespace CustomSettingManagement.Web;

public class CustomSettingManagementWebAutoMapperProfile : Profile
{
    public CustomSettingManagementWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<SystemSchedulerSettingsDto, SystemSchedulerViewComponent.ViewModel>();
    }
}
