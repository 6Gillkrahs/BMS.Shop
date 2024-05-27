using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BMS.Shop.Data;

/* This is used if database provider does't define
 * IShopDbSchemaMigrator implementation.
 */
public class NullShopDbSchemaMigrator : IShopDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
