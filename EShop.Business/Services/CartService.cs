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
    public class CartService : ICartService
    {
        private readonly IUnitOfWork data;
        private readonly IMapper mapper;

        public CartService(IUnitOfWork data, IMapper mapper) => (this.data, this.mapper) = (data, mapper);

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

        public float CalculateSum(IEnumerable<ProductModel> products)
        {
            return products.Select(item => item.Price).Sum();
        }

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

