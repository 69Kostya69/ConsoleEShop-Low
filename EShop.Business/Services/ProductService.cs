using AutoMapper;
using EShop.Business.Business_Logic;
using EShop.Business.Interfaces;
using EShop.Business.Models;
using EShop.Data.Entities;
using EShop.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace EShop.Business.Services
{
    /// <summary>
    /// Provides crud actions for product data
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _data;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork data, IMapper mapper)
        {
            this._data = data;
            this._mapper = mapper;
        }

        /// <summary>
        /// Gives product by id
        /// </summary>
        /// <param name="id"> id of the product</param>
        /// <returns> Product with all properties</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws when id of the product is invalid</exception>
        public ProductModel Get(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Value must be positive");

            return _mapper.Map<ProductModel>(_data.Products.Get(id));
        }

        /// <summary>
        ///  Gives all products
        /// </summary>
        /// <returns>List of product data</returns>
        public IEnumerable<ProductModel> GetAll() => _mapper.Map<IEnumerable<ProductModel>>(_data.Products.GetAll());

        /// <summary>
        /// Give all products by category
        /// </summary>
        /// <param name="type">type of product</param>
        /// <returns>List products</returns>
        public IEnumerable<ProductModel> GetProductsByCategory(ProductType type) => _mapper.Map<IEnumerable<ProductModel>>(new Filters(_data).GetProductsCategory(type));

    }
}
