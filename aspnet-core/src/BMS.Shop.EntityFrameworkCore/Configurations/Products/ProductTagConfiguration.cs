﻿using BMS.Shop.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Shop.Configurations.Products
{
    public class ProductTagConfiguration : IEntityTypeConfiguration<ProductTag>
    {
        public void Configure(EntityTypeBuilder<ProductTag> builder)
        {
            builder.ToTable(ShopConsts.DbTablePrefix + "ProductTags");
            builder.HasKey(x => new { x.ProductId, x.TagId });
        }
    }
}
