using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Olympic.Trader.Store.Domain.Products;

public class Product : FullAuditedAggregateRoot<Guid>
{

    public string Name { get; set; }

    public decimal Price { get; set; }

    public bool IsAvailable { get; set; } = true;

}