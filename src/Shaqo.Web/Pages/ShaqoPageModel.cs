using Shaqo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Shaqo.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ShaqoPageModel : AbpPageModel
{
    protected ShaqoPageModel()
    {
        LocalizationResourceType = typeof(ShaqoResource);
    }
}
