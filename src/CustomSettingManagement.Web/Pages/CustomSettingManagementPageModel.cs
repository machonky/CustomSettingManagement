using CustomSettingManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CustomSettingManagement.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class CustomSettingManagementPageModel : AbpPageModel
{
    protected CustomSettingManagementPageModel()
    {
        LocalizationResourceType = typeof(CustomSettingManagementResource);
    }
}
