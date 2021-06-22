using EShop.Data.Entities;
using EShop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Data.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        public void Create(Product item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Find(Func<Product, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
