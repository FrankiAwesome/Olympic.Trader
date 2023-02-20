using Localization.Resources.AbpUi;
using Olympic.Trader.Store.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Olympic.Trader.Store;

[DependsOn(
    typeof(StoreApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class StoreHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(StoreHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<StoreResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
