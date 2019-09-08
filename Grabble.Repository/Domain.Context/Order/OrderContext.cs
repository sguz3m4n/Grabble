﻿using Grabble.Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace Grabble.Repository
{
    public class OrderContext : DbContext
    {    
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseMySql();
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            //create order map method in Grabble.Data project
            //mapping examples in file
            new OrderMap(modelbuilder.Entity<Order>());
        }

    }
}
