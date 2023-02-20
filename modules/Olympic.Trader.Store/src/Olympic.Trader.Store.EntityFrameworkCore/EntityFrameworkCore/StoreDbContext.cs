using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Olympic.Trader.Store.EntityFrameworkCore;

[ConnectionStringName(StoreDbProperties.ConnectionStringName)]
public class StoreDbContext : AbpDbContext<StoreDbContext>, IStoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public StoreDbContext(DbContextOptions<StoreDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureStore();
    }
}
