using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Cataring.Domain.Commands
{
  public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(string firstName, string lastName,string phoneNumber, string eventLocation, string address, decimal totalAmount)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            EventLocation = eventLocation;
            Address = address;
            TotalAmount = totalAmount;
    }
    }
}
