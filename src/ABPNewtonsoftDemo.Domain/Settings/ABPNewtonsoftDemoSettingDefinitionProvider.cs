using Volo.Abp.Settings;

namespace ABPNewtonsoftDemo.Settings;

public class ABPNewtonsoftDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ABPNewtonsoftDemoSettings.MySetting1));
    }
}
