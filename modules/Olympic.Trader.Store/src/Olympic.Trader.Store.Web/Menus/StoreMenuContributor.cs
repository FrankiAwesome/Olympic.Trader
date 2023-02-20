using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Olympic.Trader.Store.Web.Menus;

public class StoreMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(StoreMenus.Prefix, displayName: "Store", "~/Store", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
