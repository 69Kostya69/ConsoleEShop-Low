using EShop.Data.Entities;

namespace EShop.Data.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetProductByName(string productName);
    }
}
