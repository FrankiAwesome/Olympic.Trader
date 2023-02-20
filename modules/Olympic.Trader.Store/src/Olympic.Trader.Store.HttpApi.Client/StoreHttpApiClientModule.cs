using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Olympic.Trader.Store;

[DependsOn(
    typeof(StoreApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class StoreHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(StoreApplicationContractsModule).Assembly,
            StoreRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<StoreHttpApiClientModule>();
        });

    }
}
