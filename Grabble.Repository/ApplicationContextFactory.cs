﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Grabble.Repository
{
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.Development.json", optional: false, reloadOnChange: true)
            .Build();

            var connectionString = configuration.GetConnectionString("connDevelopment");

            //optionsBuilder.UseMySql(connectionString, b => b.MigrationsAssembly("Grabble.Order.Api"));
            optionsBuilder.UseMySql(connectionString);

            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}

