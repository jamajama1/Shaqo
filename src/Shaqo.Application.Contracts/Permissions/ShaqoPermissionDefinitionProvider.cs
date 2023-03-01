using Shaqo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Shaqo.Permissions;

public class ShaqoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var shaqoGroup = context.AddGroup(ShaqoPermissions.GroupName, L("Permission:Jobs"));
        var jobsPermission = shaqoGroup.AddPermission(ShaqoPermissions.Jobs.Default, L("Permission:Jobs"));
        jobsPermission.AddChild(ShaqoPermissions.Jobs.Create, L("Permission:Jobs.Create"));
        jobsPermission.AddChild(ShaqoPermissions.Jobs.Edit, L("Permission:Jobs.Edit"));
        jobsPermission.AddChild(ShaqoPermissions.Jobs.Delete, L("Permission:Jobs.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ShaqoResource>(name);
    }
}
