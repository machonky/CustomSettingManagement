using CustomSettingManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CustomSettingManagement.Permissions;

public abstract class CustomSettingManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    //public override void Define(IPermissionDefinitionContext context)
    //{
    //    var myGroup = context.AddGroup(CustomSettingManagementPermissions.GroupName);
    //    //Define your own permissions here. Example:
    //    //myGroup.AddPermission(CustomSettingManagementPermissions.MyPermission1, L("Permission:MyPermission1"));
    //}

    protected static LocalizableString L(string name)
    {
        return LocalizableString.Create<CustomSettingManagementResource>(name);
    }
}
