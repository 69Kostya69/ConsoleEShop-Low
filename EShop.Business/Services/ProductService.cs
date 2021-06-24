using AutoMapper;
using EShop.Business.Business_Logic;
using EShop.Business.Interfaces;
using EShop.Business.Models;
using EShop.Data.Entities;
using EShop.Data.Interfaces;
using System.Collections.Generic;

namespace EShop.Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _data;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork data, IMapper mapper)
        {
            this._data = data;
            this._mapper = mapper;
        }
        public ProductModel Get(int id) => _mapper.Map<ProductModel>(_data.Products.Get(id));

        public IEnumerable<ProductModel> GetAll() => _mapper.Map<IEnumerable<ProductModel>>(_data.Products.GetAll());

        public IEnumerable<ProductModel> GetProductsByCategory(ProductType type) => _mapper.Map<IEnumerable<ProductModel>>(new Filters(_data).GetProductsCategory(type));

    }
}
