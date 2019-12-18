using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Models.DTO
{
    public class ReceiverDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EventLocation { get; set; }
        public string Address { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
