using EShop.Business.Models;
using System.Collections.Generic;

namespace EShop.Business.Interfaces
{
    public interface ICartService
    {
        void AddToCart(int userId, int productId);
        void RemoveFromCart(int userId, int productid);
        float CalculateSum(IEnumerable<ProductModel> products);
        IEnumerable<ProductModel> GetCartProducts(int userId);
    }
}
