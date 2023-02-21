using Olympic.Trader.Store.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Olympic.Trader.Store.Permissions;

public class StorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StorePermissions.GroupName, L("Permission:Store"));
        
        var productPermissionGroup = myGroup.AddPermission(StorePermissions.Products.Default,
            L("Permission:Products"));
        productPermissionGroup.AddChild(StorePermissions.Products.Create,
            L("Permission:Products.Create"));
        productPermissionGroup.AddChild(StorePermissions.Products.Edit,
            L("Permission:Products.Edit"));
        productPermissionGroup.AddChild(StorePermissions.Products.Delete,
            L("Permission:Products.Delete"));
        productPermissionGroup.AddChild(StorePermissions.Products.AllowGetAvailability,
            L("Permission:Products.AllowGetAvailability"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StoreResource>(name);
    }
}
