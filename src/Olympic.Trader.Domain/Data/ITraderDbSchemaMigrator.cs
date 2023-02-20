using System.Threading.Tasks;

namespace Olympic.Trader.Data;

public interface ITraderDbSchemaMigrator
{
    Task MigrateAsync();
}
