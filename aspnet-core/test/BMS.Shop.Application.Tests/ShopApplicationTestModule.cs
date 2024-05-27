using Volo.Abp.Modularity;

namespace BMS.Shop;

[DependsOn(
    typeof(ShopApplicationModule),
    typeof(ShopDomainTestModule)
)]
public class ShopApplicationTestModule : AbpModule
{

}
