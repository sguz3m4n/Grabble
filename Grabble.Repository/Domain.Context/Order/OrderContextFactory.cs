using Grabble.Repository.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.IO;

namespace Grabble.Repository.Domain.Order
{
  public class OrderContextFactory : IDesignTimeDbContextFactory<OrderContext>
  {
   
    public OrderContext CreateDbContext(string[] args)
    {
            var optionsBuilder = new DbContextOptionsBuilder<OrderContext>();

            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.Development.json", optional: false, reloadOnChange: true)
            .Build();

            var connectionString = configuration.GetConnectionString("connDevelopment");

            optionsBuilder.UseMySql(connectionString, b => b.MigrationsAssembly("Grabble.Order.Api"));

            return new OrderContext(optionsBuilder.Options);
        }
  }
}
