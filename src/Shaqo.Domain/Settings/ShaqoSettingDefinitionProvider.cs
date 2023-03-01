using Volo.Abp.Settings;

namespace Shaqo.Settings;

public class ShaqoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ShaqoSettings.MySetting1));
    }
}
