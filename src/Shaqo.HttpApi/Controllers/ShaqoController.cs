using Shaqo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Shaqo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ShaqoController : AbpControllerBase
{
    protected ShaqoController()
    {
        LocalizationResource = typeof(ShaqoResource);
    }
}
