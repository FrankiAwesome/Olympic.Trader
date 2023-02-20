using System;
using System.Collections.Generic;
using System.Text;
using Olympic.Trader.Localization;
using Volo.Abp.Application.Services;

namespace Olympic.Trader;

/* Inherit your application services from this class.
 */
public abstract class TraderAppService : ApplicationService
{
    protected TraderAppService()
    {
        LocalizationResource = typeof(TraderResource);
    }
}
