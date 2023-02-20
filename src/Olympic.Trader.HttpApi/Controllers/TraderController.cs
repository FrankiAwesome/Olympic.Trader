using Olympic.Trader.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Olympic.Trader.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TraderController : AbpControllerBase
{
    protected TraderController()
    {
        LocalizationResource = typeof(TraderResource);
    }
}
