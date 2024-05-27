using System;
using System.Collections.Generic;
using System.Text;
using BMS.Shop.Localization;
using Volo.Abp.Application.Services;

namespace BMS.Shop;

/* Inherit your application services from this class.
 */
public abstract class ShopAppService : ApplicationService
{
    protected ShopAppService()
    {
        LocalizationResource = typeof(ShopResource);
    }
}
