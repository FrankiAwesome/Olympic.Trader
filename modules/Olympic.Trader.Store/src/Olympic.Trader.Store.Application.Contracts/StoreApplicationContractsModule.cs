using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Olympic.Trader.Store;

[DependsOn(
    typeof(StoreDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class StoreApplicationContractsModule : AbpModule
{

}
