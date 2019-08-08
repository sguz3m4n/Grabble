using Grabble.Data.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Grabble.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Console.WriteLine(options);
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
            new ItemMap(modelbuilder.Entity<Item>());
            new ConsumerMap(modelbuilder.Entity<Consumer>());
        }
    }
}
