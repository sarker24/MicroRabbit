using MicroRabbit.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Cataring.Domain.Commands
{
  public abstract class TransferCommand: Command 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EventLocation { get; set; }
        public string Address { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
