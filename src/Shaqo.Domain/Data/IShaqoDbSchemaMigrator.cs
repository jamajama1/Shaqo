using System.Threading.Tasks;

namespace Shaqo.Data;

public interface IShaqoDbSchemaMigrator
{
    Task MigrateAsync();
}
