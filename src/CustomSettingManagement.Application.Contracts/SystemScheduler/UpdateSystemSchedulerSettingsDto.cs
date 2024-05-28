namespace CustomSettingManagement.SystemScheduler;

public class UpdateSystemSchedulerSettingsDto
{
    public int SchedulerPollingIntervalMins { get; set; }
    public int BusinessDaysLookahead { get; set; }
}