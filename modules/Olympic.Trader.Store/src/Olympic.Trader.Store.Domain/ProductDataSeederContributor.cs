using System;
using System.Threading.Tasks;
using Olympic.Trader.Store.Domain.Products;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Olympic.Trader.Store;

public class ProductDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Product, Guid> _productRepository;

    public ProductDataSeedContributor(IRepository<Product, Guid> productRepository)
    {
        _productRepository = productRepository;
    }


    public async Task SeedAsync(DataSeedContext context)
    {
        
        if (await _productRepository.GetCountAsync() == 0)
        {
            
            await  _productRepository.InsertAsync(
                new Product()
                {
                    Name = "Milk",
                    Price = new decimal(4.50)
                });
            
        }

    }
}