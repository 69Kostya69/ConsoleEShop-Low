using EShop.Data.Entities;
using EShop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EShop.Data.Repositories
{
    public class CartRepository : IRepository<Cart>
    {
        private IContext context;
        public CartRepository(IContext _context)
        {
            context = _context;
        }

        public void Create(Cart item) => context.Carts.Add(item);

        public IEnumerable<Cart> Find(Func<Cart, bool> predicate) => context.Carts.Where(predicate).ToList();

        public Cart Get(int id) => context.Carts.Where(x => x.Id == id).FirstOrDefault();

        public IEnumerable<Cart> GetAll() => context.Carts.ToList();

        public void Remove(int id) => context.Carts.Remove(Get(id));

        public void Update(Cart item)
        {
            Remove(item.Id);
            Create(item);
        }
    }
}
