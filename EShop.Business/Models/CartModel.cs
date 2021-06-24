using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Business.Models
{
    public class CartModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public IEnumerable<int> ProductIds { get; set; }
        public float Sum { get; set; }
    }
}
