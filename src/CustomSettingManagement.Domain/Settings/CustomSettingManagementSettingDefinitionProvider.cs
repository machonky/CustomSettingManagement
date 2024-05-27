using Volo.Abp.Settings;

namespace CustomSettingManagement.Settings;

public class CustomSettingManagementSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CustomSettingManagementSettings.MySetting1));
    }
}
