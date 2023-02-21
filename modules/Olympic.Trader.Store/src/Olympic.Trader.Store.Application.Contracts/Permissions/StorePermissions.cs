using Volo.Abp.Reflection;

namespace Olympic.Trader.Store.Permissions;

public class StorePermissions
{
    public const string GroupName = "Store";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(StorePermissions));
    }
    
    public static class Products
    {
        public const string Default = GroupName + ".Products"; //Store.Products
        public const string Create = Default + ".Create"; //Store.Products.Create
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
        public const string AllowGetAvailability = Default + ".AllowGetAvailability";
    }
}
