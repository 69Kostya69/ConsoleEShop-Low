using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public float Sum { get; set; }
    }
}
