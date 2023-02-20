using Olympic.Trader.Store.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Olympic.Trader.Store;

public abstract class StoreController : AbpControllerBase
{
    protected StoreController()
    {
        LocalizationResource = typeof(StoreResource);
    }
}
