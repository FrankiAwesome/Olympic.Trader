using Volo.Abp.Modularity;

namespace Olympic.Trader.Store;

[DependsOn(
    typeof(StoreApplicationModule),
    typeof(StoreDomainTestModule)
    )]
public class StoreApplicationTestModule : AbpModule
{

}
