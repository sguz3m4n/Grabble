using Grabble.Data.Domain.Order;
using Grabble.Repository.Properties;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

namespace Grabble.Repository.Context
{
  public class OrderDbContext : DbContext
  {
    #region Constructor

    public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
    {

    }

    #endregion

    #region Properties

    public DbSet<Order> OrderContext { get; set; }

    #endregion

    #region Methods

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        //use this string to target local environment
        var connlocal = Resources.mysqlDev;
        //use this string to target remote environment
        var connstage = Resources.connStage;
#if DEBUG
        optionsBuilder.UseMySql(connlocal,
                                      provideroptions => provideroptions.CommandTimeout(60))
                                  .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
#else
                optionsBuilder.UseSqlServer(connstage,
                                                   provideroptions => provideroptions.CommandTimeout(60))
                                               .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
#endif


      }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      //builder.Entity<PoliceOfficer>().ToTable("PoliceOfficer");
      // Customize the ASP.NET Identity model and override the defaults if needed.
      // For example, you can rename the ASP.NET Identity table names and more.
      // Add your customizations after calling base.OnModelCreating(builder);
    }

    #endregion

  }
}
