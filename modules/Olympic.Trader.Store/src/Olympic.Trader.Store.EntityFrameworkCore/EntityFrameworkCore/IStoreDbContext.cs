using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Olympic.Trader.Store.EntityFrameworkCore;

[ConnectionStringName(StoreDbProperties.ConnectionStringName)]
public interface IStoreDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
