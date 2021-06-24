using EShop.Business.Models;
using System.Collections.Generic;

namespace EShop.Business.Interfaces
{
    public interface IOrderService
    {
        void MakeOrder(OrderModel order);
        IEnumerable<ProductModel> GetOrderProducts(int userId);
    }
}
