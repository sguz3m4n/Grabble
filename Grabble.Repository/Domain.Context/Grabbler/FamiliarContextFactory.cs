using Grabble.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Grabble.Repository
{
    public class FamiliarContextFactory:IDesignTimeDbContextFactory<FamiliarContext>
    {
        public virtual DbSet<Familiar> FamiliarDbContext { get; set; }
        public FamiliarContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FamiliarContext>();

            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.Development.json", optional: false, reloadOnChange: true)
            .Build();

            var connectionString = configuration.GetConnectionString("connDevelopment");

            optionsBuilder.UseMySql(connectionString);

            return new FamiliarContext(optionsBuilder.Options);
        }
    }
}
