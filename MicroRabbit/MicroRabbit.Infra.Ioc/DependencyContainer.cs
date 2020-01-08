using MediatR;
using MicroRabbit.Cataring.Application.Interfaces;
using MicroRabbit.Cataring.Application.Services;
using MicroRabbit.Cataring.Data.Context;
using MicroRabbit.Cataring.Data.Repository;
using MicroRabbit.Cataring.Domain.CommandHandlers;
using MicroRabbit.Cataring.Domain.Commands;
using MicroRabbit.Cataring.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Application.Services;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Data.Repository;
using MicroRabbit.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain bus 
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Domain cataring commands>

            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            // Application services

            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<ITransferService, TransferService>();


            //Data

            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<CataringDBContext>();
            services.AddTransient<TransferDBContext>();

        }
    }
}
