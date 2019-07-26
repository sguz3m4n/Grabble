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
#if DEBUG
optionsBuilder.UseSqlServer(Resources.connLocalMSSQLLocalDB);
#else
            optionsBuilder.UseSqlServer(Resources.connStage); optionsBuilder.UseSqlServer(Resources.connStage);
#endif


            return new OrderDbContext(optionsBuilder.Options);
        }
    }
}
