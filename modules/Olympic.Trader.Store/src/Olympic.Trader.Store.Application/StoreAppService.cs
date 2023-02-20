using Olympic.Trader.Store.Localization;
using Volo.Abp.Application.Services;

namespace Olympic.Trader.Store;

public abstract class StoreAppService : ApplicationService
{
    protected StoreAppService()
    {
        LocalizationResource = typeof(StoreResource);
        ObjectMapperContext = typeof(StoreApplicationModule);
    }
}
