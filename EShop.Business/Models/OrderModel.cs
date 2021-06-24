using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Business.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CartId { get; set; }
        public float Sum { get; set; }
    }
}
