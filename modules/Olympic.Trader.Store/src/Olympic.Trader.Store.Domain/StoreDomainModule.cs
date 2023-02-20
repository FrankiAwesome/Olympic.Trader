using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Olympic.Trader.Store;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(StoreDomainSharedModule)
)]
public class StoreDomainModule : AbpModule
{

}
