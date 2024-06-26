﻿using CustomSettingManagement.Permissions;

namespace CustomSettingManagement.SystemScheduler;

public class SystemSchedulerPermissions : CustomSettingManagementPermissions
{
    public static class SystemScheduler
    {
        public const string GroupName = ModuleName + "." + nameof(SystemScheduler);
        public const string HostSideGroup = GroupName + HostGroupPrefix;
        public const string TenantSideGroup = GroupName + TenantGroupPrefix;

        public const string EditSchedulerPollingInterval = GroupName + "." + nameof(EditSchedulerPollingInterval);
    }
}