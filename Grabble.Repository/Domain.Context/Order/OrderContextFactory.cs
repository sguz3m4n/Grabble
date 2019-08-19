using Grabble.Repository.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MySql.Data.MySqlClient;

namespace Grabble.Repository.Domain.Order
{
  public class OrderContextFactory : IDesignTimeDbContextFactory<OrderContext>
  {
    //migration commands will target this method to create database
    //
    public OrderContext CreateDbContext(string[] args)
    {
      var optionsBuilder = new DbContextOptionsBuilder<OrderContext>();
      //use the resource connection string to switch database targets
      // #if DEBUG
      //       optionsBuilder.UseMySql(Resources.mysqlDev);
      // #else
      //       optionsBuilder.UseSqlServer(Resources.connStage);
      // #endif


      return new OrderContext(optionsBuilder.Options);
    }
  }
}
