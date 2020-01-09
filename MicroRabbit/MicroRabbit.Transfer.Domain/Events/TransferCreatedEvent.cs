using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Domain.Events
{
   public class TransferCreatedEvent : Event
    {
        public string FirstName { get;private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string EventLocation { get; private set; }
        public string Address { get; private set; }
        public decimal TotalAmount { get; private set; }

        public TransferCreatedEvent(string firstName, string lastName, string phoneNumber, string eventLocation, string address, decimal totalAmount)
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
