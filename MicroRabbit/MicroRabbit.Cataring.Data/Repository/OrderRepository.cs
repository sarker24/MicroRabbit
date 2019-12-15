using MicroRabbit.Cataring.Data.Context;
using MicroRabbit.Cataring.Domain.Interfaces;
using MicroRabbit.Cataring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Cataring.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private CataringDBContext _Ctx;

        public OrderRepository(CataringDBContext Ctx)
        {
            _Ctx = Ctx;
        }
        public IEnumerable<Order> GetOrders()
        {
           return _Ctx.Orders;
        }
    }
}
