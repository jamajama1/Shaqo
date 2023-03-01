using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Shaqo.Web;

[Dependency(ReplaceServices = true)]
public class ShaqoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Shaqo";
}
