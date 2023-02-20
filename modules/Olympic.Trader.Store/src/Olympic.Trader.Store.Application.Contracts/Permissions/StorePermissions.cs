using Volo.Abp.Reflection;

namespace Olympic.Trader.Store.Permissions;

public class StorePermissions
{
    public const string GroupName = "Store";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(StorePermissions));
    }
}
