using System;
using Volo.Abp.Application.Dtos;

namespace Olympic.Trader.Store.Application.Contracts.Products;

public class ProductDto : FullAuditedEntityDto<Guid>
{
    
    public string Name { get; set; }

    public decimal Price { get; set; }

    public bool IsAvailable { get; set; }
    
}