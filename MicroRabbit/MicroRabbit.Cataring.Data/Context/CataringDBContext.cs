using MicroRabbit.Cataring.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Cataring.Data.Context
{
   public class CataringDBContext: DbContext
    {
        public CataringDBContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
    }
}
