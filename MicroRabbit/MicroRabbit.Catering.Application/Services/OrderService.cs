using MicroRabbit.Cataring.Application.Interfaces;
using MicroRabbit.Cataring.Domain.Interfaces;
using MicroRabbit.Cataring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Cataring.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public IEnumerable<Order> GetOrders()
        {
           return _orderRepository.GetOrders();
        }
    }
}
