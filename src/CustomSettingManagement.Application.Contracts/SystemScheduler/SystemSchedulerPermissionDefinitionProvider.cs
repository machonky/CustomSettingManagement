using CustomSettingManagement.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.MultiTenancy;

namespace CustomSettingManagement.SystemScheduler;

public class SystemSchedulerPermissionDefinitionProvider : CustomSettingManagementPermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var hostGroup = context.AddGroup(SystemSchedulerPermissions.SystemScheduler.GroupName, L("Permission:"+ SystemSchedulerPermissions.SystemScheduler.GroupName));
        hostGroup.AddPermission(SystemSchedulerPermissions.SystemScheduler.GroupName, L("Permission:" + SystemSchedulerPermissions.SystemScheduler.GroupName), MultiTenancySides.Both);
        hostGroup.AddPermission(SystemSchedulerPermissions.SystemScheduler.EditPollingInterval, L("Permission:" + SystemSchedulerPermissions.SystemScheduler.EditPollingInterval), MultiTenancySides.Host);
        hostGroup.AddPermission(SystemSchedulerPermissions.SystemScheduler.EditBusinessDaysLookahead, L("Permission:" + SystemSchedulerPermissions.SystemScheduler.EditBusinessDaysLookahead), MultiTenancySides.Both);
    }
}
