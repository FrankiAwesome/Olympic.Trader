using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Olympic.Trader.Store.Application.Contracts.Products;
using Olympic.Trader.Store.Domain.Products;
using Olympic.Trader.Store.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Olympic.Trader.Store.Application.Products;

public class ProductAppService : CrudAppService<
        Product,
        ProductDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateProductInput,
        UpdateProductInput>
    ,IProductAppService
{
    private readonly IRepository<Product, Guid> _productRepository;
    
    public ProductAppService(IRepository<Product, Guid> repository) : base(repository)
    {

        _productRepository = repository;
        
        GetPolicyName = StorePermissions.Products.Default;
        GetListPolicyName = StorePermissions.Products.Default;
        CreatePolicyName = StorePermissions.Products.Create;
        UpdatePolicyName = StorePermissions.Products.Edit;
        DeletePolicyName = StorePermissions.Products.Delete;
        
    }

    [Authorize(StorePermissions.Products.AllowGetAvailability)]
    public async Task<List<ProductDto>> GetProductsByAvailabilityAsync(bool isAvailable)
    {
        //TODO: Not Performant
        var result = (await _productRepository.GetListAsync())
            .Where(p => p.IsAvailable == isAvailable)
            .ToList();
           
        return ObjectMapper.Map<List<Product>, List<ProductDto>>(result);
    }
}