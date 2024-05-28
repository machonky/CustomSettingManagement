using Volo.Abp.Settings;

namespace CustomSettingManagement.SystemScheduler;

public class SystemSchedulerSettingProvider : CustomSettingManagementSettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        context.Add(
            new SettingDefinition(
                SystemSchedulerSettingNames.PollingInterval,
                "60",
                L("Label:SystemSchedulerSetting.PollingInterval"),
                L("Description:SystemSchedulerSetting.PollingInterval")));
        context.Add(
            new SettingDefinition(
                SystemSchedulerSettingNames.BusinessDaysLookahead,
                "3",
                L("Label:"+ SystemSchedulerSettingNames.BusinessDaysLookahead),
                L("Description:" + SystemSchedulerSettingNames.BusinessDaysLookahead)));
    }
}
