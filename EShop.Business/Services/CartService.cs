using AutoMapper;
using EShop.Business.Interfaces;
using EShop.Business.Models;
using EShop.Business.Validation;
using EShop.Data.Entities;
using EShop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EShop.Business.Services
{
    /// <summary>
    /// Provides crud actions for cart data
    /// </summary>
    public class CartService : ICartService
    {
        private readonly IUnitOfWork data;
        private readonly IMapper mapper;

        public CartService(IUnitOfWork data, IMapper mapper) => (this.data, this.mapper) = (data, mapper);

        /// <summary>
        /// Add product by id to the cart of the user 
        /// </summary>
        /// <param name="userId">id of the user</param>
        /// <param name="productId">id of the product</param>
        public void AddToCart(int userId, int productId)
        {
            Cart cart;
            int cartId = GetCartId(userId);
            if (cartId == default)
            {
                cart = new Cart() { Id = data.Carts.GetAll().LastOrDefault().Id + 1 };
                data.Carts.Create(cart);
            }

            cart = data.Carts.Get(cartId);
            cart.Products.Append(data.Products.Get(productId));
            data.Carts.Update(cart);
        }

        /// <summary>
        /// Gives summary cost of products
        /// </summary>
        /// <param name="products">List of products</param>
        /// <returns>float value cost of products</returns>
        public float CalculateSum(IEnumerable<ProductModel> products)
        {
            return products.Select(item => item.Price).Sum();
        }

        /// <summary>
        /// Gives an information about products in users cart
        /// </summary>
        /// <param name="userId">id of the user</param>
        /// <returns>List of products</returns>
        public IEnumerable<ProductModel> GetCartProducts(int userId)
        {
            Cart cart;
            int cartId = GetCartId(userId);
            if (cartId == default)
            {
                cart = new Cart() { Id = data.Carts.GetAll().LastOrDefault().Id + 1 };
                data.Carts.Create(cart);
            }
            else
                cart = data.Carts.Get(cartId);

            return mapper.Map<IEnumerable<ProductModel>>(cart.Products);
        }

        /// <summary>
        /// Remove product from cart
        /// </summary>
        /// <param name="userId">id of the user</param>
        /// <param name="id">id of the product</param>
        /// <exception cref="CustomException">Throws when cart or product in cart is empty</exception>
        public void RemoveFromCart(int userId, int id)
        {
            int cartId = GetCartId(userId);
            if (cartId == default)
                throw new CustomException("This cart is empty");

            var cart = data.Carts.Get(cartId);

            var product = cart.Products.FirstOrDefault(x => x.Id == id);
            if (product == default)
                throw new CustomException("No this product");
            else
                cart.Products.ToList().Remove(product);

            data.Carts.Update(cart);
        }

        private int GetCartId(int userId)
        {
            return data.Carts.Find(x => x.ClientId == userId).FirstOrDefault().Id;
        }
    }
}

