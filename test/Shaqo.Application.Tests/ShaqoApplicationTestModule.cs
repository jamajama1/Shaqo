using Volo.Abp.Modularity;

namespace Shaqo;

[DependsOn(
    typeof(ShaqoApplicationModule),
    typeof(ShaqoDomainTestModule)
    )]
public class ShaqoApplicationTestModule : AbpModule
{

}
