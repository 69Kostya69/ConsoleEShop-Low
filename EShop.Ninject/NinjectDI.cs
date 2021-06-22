using EShop.Data;
using EShop.Data.Entities;
using EShop.Data.Interfaces;
using EShop.Data.Repositories;
using Ninject;
using System;

namespace EShop.Ninject
{
    public static class NinjectDI
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind<IContext>().To<FakeDb>();
            kernel.Bind<IUserRepository>().To<UserRepository>();
            kernel.Bind<IRepository<Product>>().To<ProductRepository>();
        }
    }
}
