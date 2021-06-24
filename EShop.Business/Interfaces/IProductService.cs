using EShop.Business.Models;
using EShop.Data.Entities;
using System.Collections.Generic;

namespace EShop.Business.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductModel> GetAll();
        ProductModel Get(int id);
        IEnumerable<ProductModel> GetProductsByCategory(ProductType type);
    }
}
