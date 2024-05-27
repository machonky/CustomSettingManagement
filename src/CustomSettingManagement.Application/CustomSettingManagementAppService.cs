using System;
using System.Collections.Generic;
using System.Text;
using CustomSettingManagement.Localization;
using Volo.Abp.Application.Services;

namespace CustomSettingManagement;

/* Inherit your application services from this class.
 */
public abstract class CustomSettingManagementAppService : ApplicationService
{
    protected CustomSettingManagementAppService()
    {
        LocalizationResource = typeof(CustomSettingManagementResource);
    }
}
