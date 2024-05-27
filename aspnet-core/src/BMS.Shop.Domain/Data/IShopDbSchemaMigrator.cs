using System.Threading.Tasks;

namespace BMS.Shop.Data;

public interface IShopDbSchemaMigrator
{
    Task MigrateAsync();
}
