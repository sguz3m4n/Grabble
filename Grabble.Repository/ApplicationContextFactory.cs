using Grabble.Repository.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MySql.Data.MySqlClient;

namespace Grabble.Repository
{
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var connstring = new MySqlConnectionStringBuilder
            {
                Server = Resources.connServer,
                UserID = Resources.connUserId,
                Password = Resources.connPassword,
                Database = Resources.connDatabase
            };
            var connection = new MySqlConnection(connstring.ToString());

            //use the resource connection string to point to target database 
            //optionsBuilder.UseSqlServer(Resources.connLocalProjectsV13);
#if DEBUG
            optionsBuilder.UseSqlServer(Resources.connLocalMSSQLLocalDB);        
#else
            optionsBuilder.UseMySql(connection);

#endif
            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}

