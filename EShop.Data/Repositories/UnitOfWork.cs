using EShop.Data.Entities;
using EShop.Data.Interfaces;
using System;

namespace EShop.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ProductRepository productRepository;
        private CartRepository cartRepository;
        private OrderRepository orderRepository;
        private UserRepository userRepository;

        private IContext context;

        public UnitOfWork(IContext context)
        {
            this.context = context;
        }

        public IProductRepository Products
        {
            get
            {
                return productRepository ??= new ProductRepository(context);
            }
        }

        public IRepository<Cart> Carts
        {
            get
            {
                return cartRepository ??= new CartRepository(context);
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                return orderRepository ??= new OrderRepository(context);
            }
        }

        public IUserRepository Users
        {
            get
            {
                return userRepository ??= new UserRepository(context);
            }
        }

        private bool disposed = false;

        // реализация интерфейса IDisposable.
        public void Dispose()
        {
            Dispose(true);
            // подавляем финализацию
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Освобождаем управляемые ресурсы
                }
                // освобождаем неуправляемые объекты
                disposed = true;
            }
        }
    }
}
