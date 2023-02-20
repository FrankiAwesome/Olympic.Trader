using Olympic.Trader.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Olympic.Trader.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TraderEntityFrameworkCoreModule),
    typeof(TraderApplicationContractsModule)
    )]
public class TraderDbMigratorModule : AbpModule
{

}
