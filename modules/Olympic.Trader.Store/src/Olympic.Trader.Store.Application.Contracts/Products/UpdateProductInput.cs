using System.ComponentModel.DataAnnotations;
using Olympic.Trader.Store.Domain.Shared.Products;

namespace Olympic.Trader.Store.Application.Contracts.Products;

public class UpdateProductInput
{
    
    [Required]
    [StringLength(ProductConsts.MaxNameLength)]
    public string Name { get; set; }

    [Required]
    public decimal Price { get; set; }
    
    public bool IsAvailable { get; set; }
    
}