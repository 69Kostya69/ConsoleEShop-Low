using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Data.Entities
{
   public class Order
   {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public float Sum { get; set; }
        public OrderStatus Status { get; set; }

   }

    public enum OrderStatus
    {
        NewOrder = 1,
        Canceled_By_Administrator,
        Canceled_By_User,
        Payment_Received,
        Sent,
        Received,
        Completed,

    }
}
