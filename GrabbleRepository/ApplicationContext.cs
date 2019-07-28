using Grabble.Data.Domain.Order;
using Microsoft.EntityFrameworkCore;

namespace Grabble.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

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
