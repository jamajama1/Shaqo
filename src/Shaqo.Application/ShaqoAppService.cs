using System;
using System.Collections.Generic;
using System.Text;
using Shaqo.Localization;
using Volo.Abp.Application.Services;

namespace Shaqo;

/* Inherit your application services from this class.
 */
public abstract class ShaqoAppService : ApplicationService
{
    protected ShaqoAppService()
    {
        LocalizationResource = typeof(ShaqoResource);
    }
}
