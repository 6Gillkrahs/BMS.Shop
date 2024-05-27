using System;
using System.Collections.Generic;
using System.Text;

namespace BMS.Shop.Products.Dtos.Attributes
{
    public class ProductAttributeListFilterDto : BaseListFilterDto
    {
        public Guid ProductId { get; set; }
    }
}
