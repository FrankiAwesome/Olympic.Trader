using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Olympic.Trader.Store.Application.Contracts.Products;

public interface IProductAppService : ICrudAppService<
    ProductDto,
    Guid,
    PagedAndSortedResultRequestDto,
    CreateProductInput,
    UpdateProductInput>
{

    Task<List<ProductDto>> GetProductsByAvailabilityAsync(bool isAvailable);

}