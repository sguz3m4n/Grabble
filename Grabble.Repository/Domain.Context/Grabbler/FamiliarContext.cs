using Grabble.Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace Grabble.Repository
{
    public class FamiliarContext : DbContext
    {
        public virtual DbSet<Familiar> FamiliarDbContext { get; set; }

        #region Constructor
        public FamiliarContext(DbContextOptions<FamiliarContext> options) : base(options)
        {

        }

        #endregion

        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseMySql();
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            //create order map method in Grabble.Data project
            //mapping examples in file
            //new FamiliarMap(builder.Entity<Grabble.Data.Domain.Item>());
            new FamiliarMap(modelbuilder.Entity<Familiar>());
        }

        #endregion

    }
}
