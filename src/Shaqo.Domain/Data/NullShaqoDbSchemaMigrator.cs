using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Shaqo.Data;

/* This is used if database provider does't define
 * IShaqoDbSchemaMigrator implementation.
 */
public class NullShaqoDbSchemaMigrator : IShaqoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
