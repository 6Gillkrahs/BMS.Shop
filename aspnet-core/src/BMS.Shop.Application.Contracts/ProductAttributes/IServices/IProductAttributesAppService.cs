﻿using BMS.Shop.ProductAttributes.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BMS.Shop.ProductAttributes.IServices
{
    public interface IProductAttributesAppService : ICrudAppService
         <ProductAttributeDto,
         Guid,
         PagedResultRequestDto,
         CreateUpdateProductAttributeDto,
         CreateUpdateProductAttributeDto>
    {
        Task<PagedResultDto<ProductAttributeInListDto>> GetListFilterAsync(BaseListFilterDto input);
        Task<List<ProductAttributeInListDto>> GetListAllAsync();
        Task DeleteMultipleAsync(IEnumerable<Guid> ids);
    }
}
