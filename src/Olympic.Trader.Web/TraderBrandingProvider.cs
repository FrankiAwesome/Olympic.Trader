using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Olympic.Trader.Web;

[Dependency(ReplaceServices = true)]
public class TraderBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Trader";
}
