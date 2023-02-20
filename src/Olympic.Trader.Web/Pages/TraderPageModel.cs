using Olympic.Trader.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Olympic.Trader.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class TraderPageModel : AbpPageModel
{
    protected TraderPageModel()
    {
        LocalizationResourceType = typeof(TraderResource);
    }
}
