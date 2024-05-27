using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace BMS.Shop;

[Dependency(ReplaceServices = true)]
public class ShopBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Shop";
}
