using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Olympic.Trader.Store;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class StoreInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<StoreInstallerModule>();
        });
    }
}
