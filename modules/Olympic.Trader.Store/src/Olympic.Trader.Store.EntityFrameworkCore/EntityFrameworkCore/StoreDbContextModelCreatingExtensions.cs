using Microsoft.EntityFrameworkCore;
using Olympic.Trader.Store.Domain.Products;
using Olympic.Trader.Store.Domain.Shared.Products;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Olympic.Trader.Store.EntityFrameworkCore;

public static class StoreDbContextModelCreatingExtensions
{
    public static void ConfigureStore(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:*/

        builder.Entity<Product>(b =>
        {
            //Configure table & schema name
            b.ToTable(StoreDbProperties.DbTablePrefix + "Products", StoreDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Name).IsRequired().HasMaxLength(ProductConsts.MaxNameLength);
            b.Property(q => q.Price).IsRequired().HasColumnType(ProductConsts.PricePrecision);
            b.Property(q => q.IsAvailable).IsRequired();

            //Relations
            //b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        
    }
}
