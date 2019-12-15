using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Cataring.Domain.Models
{
   public class Order
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EventLocation { get; set; }
        public string Address { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
