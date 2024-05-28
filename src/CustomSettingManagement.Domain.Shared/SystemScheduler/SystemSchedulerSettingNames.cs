using CustomSettingManagement.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace CustomSettingManagement.SystemScheduler;

public class SystemSchedulerSettingNames
{
    public const string PollingInterval = nameof(PollingInterval);
    public const string BusinessDaysLookahead = nameof(BusinessDaysLookahead);
}
