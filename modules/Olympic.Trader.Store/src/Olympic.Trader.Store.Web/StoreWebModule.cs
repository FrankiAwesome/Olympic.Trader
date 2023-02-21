using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Olympic.Trader.Store.Localization;
using Olympic.Trader.Store.Web.Menus;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;
using Olympic.Trader.Store.Permissions;
using Volo.Abp.AspNetCore.Mvc;

namespace Olympic.Trader.Store.Web;

[DependsOn(
    typeof(StoreApplicationContractsModule),
    typeof(AbpAspNetCoreMvcUiThemeSharedModule),
    typeof(AbpAutoMapperModule)
    )]
public class StoreWebModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
        {
            options.AddAssemblyResource(typeof(StoreResource), typeof(StoreWebModule).Assembly);
        });

        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(StoreWebModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureAutoApiControllers();

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new StoreMenuContributor());
        });

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<StoreWebModule>();
        });

        context.Services.AddAutoMapperObjectMapper<StoreWebModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<StoreWebModule>(validate: true);
        });

        Configure<RazorPagesOptions>(options =>
        {
                //Configure authorization.
            });
    }
    
    private void ConfigureAutoApiControllers()
    {
        Configure<AbpAspNetCoreMvcOptions>(options =>
        {
            options.ConventionalControllers.Create(typeof(StoreApplicationModule).Assembly);
        });
    }
}
