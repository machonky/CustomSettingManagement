using CustomSettingManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CustomSettingManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CustomSettingManagementController : AbpControllerBase
{
    protected CustomSettingManagementController()
    {
        LocalizationResource = typeof(CustomSettingManagementResource);
    }
}
