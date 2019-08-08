using Grabble.Repository.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MySql.Data.MySqlClient;

namespace Grabble.Repository.Domain
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
      optionsBuilder.UseMySql(Resources.mysqlDev);
#else
      optionsBuilder.UseSqlServer(Resources.connStage);
#endif


      return new OrderDbContext(optionsBuilder.Options);
    }
  }
}
