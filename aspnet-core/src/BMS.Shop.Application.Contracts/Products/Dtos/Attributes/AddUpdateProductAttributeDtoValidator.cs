﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BMS.Shop.Products.Dtos.Attributes
{
    public class AddUpdateProductAttributeDtoValidator : AbstractValidator<AddUpdateProductAttributeDto>
    {
        public AddUpdateProductAttributeDtoValidator()
        {
            RuleFor(x => x.ProductId).NotEmpty();
            RuleFor(x => x.AttributeId).NotEmpty();
        }
    }
}
