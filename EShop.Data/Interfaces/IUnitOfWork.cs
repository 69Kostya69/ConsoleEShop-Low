using EShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        IProductRepository Products { get; }
        IRepository<Order> Orders { get; }
        IRepository<Cart> Carts { get; }
    }
}
