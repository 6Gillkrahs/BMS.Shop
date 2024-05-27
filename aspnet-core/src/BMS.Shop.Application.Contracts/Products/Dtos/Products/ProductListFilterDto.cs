using System;
using System.Collections.Generic;
using System.Text;

namespace BMS.Shop.Products.Dtos.Products
{
    public class ProductListFilterDto : BaseListFilterDto
    {
        public Guid? CategoryId { get; set; }
    }
}
