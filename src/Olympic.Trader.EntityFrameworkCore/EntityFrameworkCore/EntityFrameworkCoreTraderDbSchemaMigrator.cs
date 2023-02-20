using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Olympic.Trader.Data;
using Volo.Abp.DependencyInjection;

namespace Olympic.Trader.EntityFrameworkCore;

public class EntityFrameworkCoreTraderDbSchemaMigrator
    : ITraderDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTraderDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TraderDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TraderDbContext>()
            .Database
            .MigrateAsync();
    }
}
