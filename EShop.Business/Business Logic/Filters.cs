using EShop.Data.Entities;
using EShop.Data.Interfaces;
using System.Collections.Generic;

namespace EShop.Business.Business_Logic
{
    public class Filters
    {
        private readonly IUnitOfWork data;

        public Filters(IUnitOfWork data) => this.data = data;

        public IEnumerable<Product> GetProductsCategory(ProductType type) => data.Products.Find(x => x.ProductType == type);
    }
}
