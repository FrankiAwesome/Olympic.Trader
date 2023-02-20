using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Olympic.Trader.Store;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StoreHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class StoreConsoleApiClientModule : AbpModule
{

}
