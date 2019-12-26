using MicroRabbit.Cataring.Application.Models;
using MicroRabbit.Cataring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Cataring.Application.Interfaces
{
   public interface IOrderService
    {
        IEnumerable<Order> GetOrders();

        void Transfer(OrderTransfer orderTransfer);
    }

}
