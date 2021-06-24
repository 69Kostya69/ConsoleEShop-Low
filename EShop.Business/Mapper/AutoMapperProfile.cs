using AutoMapper;
using EShop.Business.Models;
using EShop.Data.Entities;
using System.Linq;

namespace EShop.Business.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, RegisterModel>()
                .ReverseMap();

            CreateMap<Product, ProductModel>()
                .ReverseMap();

            CreateMap<Cart, CartModel>()
                .ForMember(x => x.ProductIds, y => y.MapFrom(z => z.Products.Select(a => a.Id)))
                .ReverseMap();

            CreateMap<Order, OrderModel>()
                .ForMember(x => x.UserId, y => y.MapFrom(z => z.UserId))
                .ForMember(x => x.CartId, y => y.MapFrom(z => z.CartId))
                .ReverseMap();
        }
    }
}
