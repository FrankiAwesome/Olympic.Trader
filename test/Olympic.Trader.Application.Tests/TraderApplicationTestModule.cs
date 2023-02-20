using Volo.Abp.Modularity;

namespace Olympic.Trader;

[DependsOn(
    typeof(TraderApplicationModule),
    typeof(TraderDomainTestModule)
    )]
public class TraderApplicationTestModule : AbpModule
{

}
