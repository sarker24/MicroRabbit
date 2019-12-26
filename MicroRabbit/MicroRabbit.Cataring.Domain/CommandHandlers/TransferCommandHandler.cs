using MediatR;
using MicroRabbit.Cataring.Domain.Commands;
using MicroRabbit.Cataring.Domain.Events;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroRabbit.Cataring.Domain.CommandHandlers
{
    
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            // publish event to rabbitMQ 
            _bus.Publish(new TransferCreatedEvent(request.FirstName, request.LastName, request.PhoneNumber, request.EventLocation, request.Address, request.TotalAmount));

            return Task.FromResult(true);
        }
    }
}
