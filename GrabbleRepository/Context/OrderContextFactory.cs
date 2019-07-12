using Grabble.Repository.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Grabble.Repository.Context
{
    public class OrderContextFactory : IDesignTimeDbContextFactory<OrderDbContext>
    {
        //migration commands will target this method to create database
        //
        public OrderDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OrderDbContext>();
            //use the resource connection string to switch database targets
            optionsBuilder.UseSqlServer(Resources.connLocalMSSQLLocalDB);

            return new OrderDbContext(optionsBuilder.Options);
        }
    }
}
