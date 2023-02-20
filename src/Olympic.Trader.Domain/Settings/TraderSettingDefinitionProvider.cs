using Volo.Abp.Settings;

namespace Olympic.Trader.Settings;

public class TraderSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TraderSettings.MySetting1));
    }
}
