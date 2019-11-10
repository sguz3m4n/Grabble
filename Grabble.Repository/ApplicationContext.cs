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
            new ConsumerMap(modelbuilder.Entity<Consumer>());
            //consumers place orders
            new OrderMap(modelbuilder.Entity<Order>());
            //chooses familiar grabbler
            new FamiliarMap(modelbuilder.Entity<Familiar>());
            //grabbler enters flight itinerary
            new FlightMap(modelbuilder.Entity<Flight>());

            //manufacturer enters item info into Grabble
            new ItemMap(modelbuilder.Entity<Item>());
            //manufacturer enters stock info into Grabble
            new StockMap(modelbuilder.Entity<Stock>());

            //assemble order contents
            new ContentMap(modelbuilder.Entity<Content>());
            //place contents into Grabble container
            new ContainerMap(modelbuilder.Entity<Container>());
        }
    }
}
