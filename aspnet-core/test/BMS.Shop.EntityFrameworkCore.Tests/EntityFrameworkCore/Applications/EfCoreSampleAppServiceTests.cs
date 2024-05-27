using BMS.Shop.Samples;
using Xunit;

namespace BMS.Shop.EntityFrameworkCore.Applications;

[Collection(ShopTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ShopEntityFrameworkCoreTestModule>
{

}
