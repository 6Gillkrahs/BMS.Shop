using Volo.Abp.Modularity;

namespace BMS.Shop;

[DependsOn(
    typeof(ShopDomainModule),
    typeof(ShopTestBaseModule)
)]
public class ShopDomainTestModule : AbpModule
{

}
