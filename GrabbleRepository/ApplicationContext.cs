using Grabble.Data.Domain.Order;
using Microsoft.EntityFrameworkCore;
using Grabble.Repository.Properties;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Grabble.Repository
{
  public class ApplicationContext : DbContext
  {
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

      //For some reason if this si present the migration fails, but if it is absent the application fails
      optionsBuilder.UseMySql(Resources.mysqlDev);
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
