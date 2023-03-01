using Shaqo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Shaqo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ShaqoEntityFrameworkCoreModule),
    typeof(ShaqoApplicationContractsModule)
    )]
public class ShaqoDbMigratorModule : AbpModule
{

}
