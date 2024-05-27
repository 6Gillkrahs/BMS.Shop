using Volo.Abp.Modularity;

namespace BMS.Shop;

public abstract class ShopApplicationTestBase<TStartupModule> : ShopTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
