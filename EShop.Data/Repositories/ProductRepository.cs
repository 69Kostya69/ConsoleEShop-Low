using EShop.Data.Entities;
using EShop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EShop.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private IContext context;
        public ProductRepository(IContext _context)
        {
            context = _context;
        }

        public void Create(Product item) => context.Products.Add(item);

        public IEnumerable<Product> Find(Func<Product, bool> predicate) => context.Products.Where(predicate).ToList();

        public Product Get(int id) => context.Products.Where(x => x.Id == id).FirstOrDefault();

        public IEnumerable<Product> GetAll() => context.Products.ToList();

        public Product GetProductByName(string productName) => context.Products.Where(x => x.Name == productName).FirstOrDefault();

        public void Remove(int id) => context.Products.Remove(Get(id));

        public void Update(Product item)
        {
            Remove(item.Id);
            Create(item);
        }

    }
}
