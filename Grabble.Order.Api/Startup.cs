using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grabble.Repository;
using Grabble.Repository.Interface;
using Grabble.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Order.Api
{
  public class Startup
  {
    private IHostingEnvironment CurrentEnvironment { get; set; }
    public Startup(IConfiguration configuration, IHostingEnvironment env)
    {
      Configuration = configuration;
      CurrentEnvironment = env;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
      {
        services.AddMvc();
        if (CurrentEnvironment.IsProduction())
        {
          Console.WriteLine("Production Mode");
          services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Grabble.Order.Api")));
        }
        else
        {
          Console.WriteLine("Dev / Staging Mode");
          services.AddDbContext<ApplicationContext>(options => options.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
        }

        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddTransient<IItemService, ItemService>();

      }

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseMvc();
    }
  }
}
