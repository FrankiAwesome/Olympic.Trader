using AutoMapper;
using Olympic.Trader.Store.Application.Contracts.Products;
using Olympic.Trader.Store.Domain.Products;

namespace Olympic.Trader.Store;

public class StoreApplicationAutoMapperProfile : Profile
{
    public StoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Product, ProductDto>();
        CreateMap<CreateProductInput, Product>();
        CreateMap<UpdateProductInput, Product>();
    }
}
