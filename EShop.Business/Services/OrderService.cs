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
    /// Provides crud actions for order data
    /// </summary>
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork data;
        private readonly IMapper mapper;

        public OrderService(IUnitOfWork data, IMapper mapper) => (this.data, this.mapper) = (data, mapper);

        /// <summary>
        /// Gives an info about ordered products of curent user
        /// </summary>
        /// <param name="userId">id of the user</param>
        /// <returns>List of products</returns>
        public IEnumerable<ProductModel> GetOrderProducts(int userId)
        {
            int orderId = GetOrderId(userId);
            if (orderId == default)
                throw new CustomException("Order is empty");

            var order = data.Orders.Get(orderId);

            return mapper.Map<IEnumerable<ProductModel>>(data.Orders.Get(orderId).Cart.Products);
        }

        /// <summary>
        /// Add order to database
        /// </summary>
        /// <param name="order">order</param>
        public void MakeOrder(OrderModel order) => data.Orders.Create(mapper.Map<Order>(order));

        /// <summary>
        /// Give orderid by user id
        /// </summary>
        /// <param name="userId"> id of the user</param>
        /// <returns>integer id of the order</returns>
        private int GetOrderId(int userId)
        {
            return data.Orders.Find(x => x.UserId == userId).FirstOrDefault().Id;
        }
    }
}

