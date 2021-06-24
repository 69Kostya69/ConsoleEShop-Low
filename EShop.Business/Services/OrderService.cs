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
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork data;
        private readonly IMapper mapper;

        public OrderService(IUnitOfWork data, IMapper mapper) => (this.data, this.mapper) = (data, mapper);

        public IEnumerable<ProductModel> GetOrderProducts(int userId)
        {
            int orderId = GetOrderId(userId);
            if (orderId == default)
                throw new CustomException("Order is empty");

            var order = data.Orders.Get(orderId);

            return mapper.Map<IEnumerable<ProductModel>>(data.Orders.Get(orderId).Cart.Products);
        }

        public void MakeOrder(OrderModel order) => data.Orders.Create(mapper.Map<Order>(order));

        private int GetOrderId(int userId)
        {
            return data.Orders.Find(x => x.UserId == userId).FirstOrDefault().Id;
        }
    }
}

