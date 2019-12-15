using MicroRabbit.Cataring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Cataring.Domain.Interfaces
{
   public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
    }
}
