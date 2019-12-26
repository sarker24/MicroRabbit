using MicroRabbit.Cataring.Application.Interfaces;
using MicroRabbit.Cataring.Application.Models;
using MicroRabbit.Cataring.Domain.Commands;
using MicroRabbit.Cataring.Domain.Interfaces;
using MicroRabbit.Cataring.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Cataring.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IEventBus _bus;

        public OrderService(IOrderRepository orderRepository, IEventBus bus)
        {
            _orderRepository = orderRepository;
            _bus = bus;
        }
        public IEnumerable<Order> GetOrders()
        {
           return _orderRepository.GetOrders();
        }

        public void Transfer(OrderTransfer orderTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(

                orderTransfer.FirstName,
                orderTransfer.LastName,
                orderTransfer.PhoneNumber,
                orderTransfer.EventLocation,
                orderTransfer.Address,
                orderTransfer.TotalAmount
                );

            _bus.SendCommand(createTransferCommand);
        }
    }
}
