using MicroRabbit.Cataring.Application.Interfaces;
using MicroRabbit.Cataring.Application.Services;
using MicroRabbit.Cataring.Data.Context;
using MicroRabbit.Cataring.Data.Repository;
using MicroRabbit.Cataring.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.Ioc
{
  public  class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain bus 
            services.AddTransient<IEventBus, RabbitMQBus>();


            // Application services

            services.AddTransient<IOrderService, OrderService>();


            //Data

            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<CataringDBContext>();
        }
     }
}
