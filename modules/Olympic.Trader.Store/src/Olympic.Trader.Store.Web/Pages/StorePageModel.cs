using Olympic.Trader.Store.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Olympic.Trader.Store.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class StorePageModel : AbpPageModel
{
    protected StorePageModel()
    {
        LocalizationResourceType = typeof(StoreResource);
        ObjectMapperContext = typeof(StoreWebModule);
    }
}
