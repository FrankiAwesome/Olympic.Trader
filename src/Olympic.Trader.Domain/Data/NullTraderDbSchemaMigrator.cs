using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Olympic.Trader.Data;

/* This is used if database provider does't define
 * ITraderDbSchemaMigrator implementation.
 */
public class NullTraderDbSchemaMigrator : ITraderDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
