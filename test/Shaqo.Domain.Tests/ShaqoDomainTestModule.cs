using Shaqo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Shaqo;

[DependsOn(
    typeof(ShaqoEntityFrameworkCoreTestModule)
    )]
public class ShaqoDomainTestModule : AbpModule
{

}
