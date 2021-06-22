using EShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Data.Interfaces
{
    public interface IContext
    {
        List<User> Users { get; set; }

        List<Product> Products { get; set; }
        List<Cart> Carts { get; set; }
        List<Order> Orders { get; set; }
    }
}
