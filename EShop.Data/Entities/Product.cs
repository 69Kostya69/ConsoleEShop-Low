using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }
        public ProductType ProductType { get; set; }
        public string Description { get; set; }
    }

    public enum ProductType : uint
    {
        Notebook = 1,
        Diary,
        Pen,
        Pencil
    }

}
