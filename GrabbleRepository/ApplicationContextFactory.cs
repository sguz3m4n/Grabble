using Grabble.Repository.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Grabble.Repository
{
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

            //use the resource connection string to switch database targets
#if DEBUG
            optionsBuilder.UseSqlServer(Resources.connLocalMSSQLLocalDB);
#else
            optionsBuilder.UseSqlServer(Resources.connStage); optionsBuilder.UseSqlServer(Resources.connStage);
#endif
            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}

