using CustomSettingManagement.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace CustomSettingManagement;

public abstract class CustomSettingManagementSettingDefinitionProvider : SettingDefinitionProvider
{
    protected static LocalizableString L(string name)
    {
        return LocalizableString.Create<CustomSettingManagementResource>(name);
    }
}
