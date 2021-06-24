using EShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Business.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }        
        public ProductType ProductType { get; set; }
        public string Description { get; set; }
    }
}
