using Xunit;

namespace BMS.Shop.EntityFrameworkCore;

[CollectionDefinition(ShopTestConsts.CollectionDefinitionName)]
public class ShopEntityFrameworkCoreCollection : ICollectionFixture<ShopEntityFrameworkCoreFixture>
{

}
