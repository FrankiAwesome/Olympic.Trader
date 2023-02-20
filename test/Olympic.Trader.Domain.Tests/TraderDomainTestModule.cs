using Olympic.Trader.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Olympic.Trader;

[DependsOn(
    typeof(TraderEntityFrameworkCoreTestModule)
    )]
public class TraderDomainTestModule : AbpModule
{

}
