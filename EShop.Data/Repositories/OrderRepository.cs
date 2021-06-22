using EShop.Data.Entities;
using EShop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EShop.Data.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private IContext context;
        public OrderRepository(IContext _context)
        {
            context = _context;
        }

        public void Create(Order item) => context.Orders.Add(item);

        public IEnumerable<Order> Find(Func<Order, bool> predicate) => context.Orders.Where(predicate).ToList();

        public Order Get(int id) => context.Orders.Where(x => x.Id == id).FirstOrDefault();

        public IEnumerable<Order> GetAll() => context.Orders.ToList();

        public void Remove(int id) => context.Orders.Remove(Get(id));

        public void Update(Order item)
        {
            Remove(item.Id);
            Create(item);
        }
    }
}
