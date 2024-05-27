using BMS.Shop.Samples;
using Xunit;

namespace BMS.Shop.EntityFrameworkCore.Domains;

[Collection(ShopTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ShopEntityFrameworkCoreTestModule>
{

}
