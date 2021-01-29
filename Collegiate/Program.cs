using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Collegiate.Data;

namespace Collegiate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            #region Code to seed database

            //var host = CreateHostBuilder(args).Build();

            //using (var scope = host.Services.CreateScope())
            //{
            //    var services = scope.ServiceProvider;
            //    CalendarDBInitializer.Seed(services);

            //    //try
            //    //{
            //    //    CalendarDBInitializer.Seed(services);
            //    //}
            //    //catch (Exception ex)
            //    //{
            //    //    var logger = services.GetRequiredService<ILogger<Program>>();
            //    //    logger.LogError(ex, "An error occurred seeding the DB.");
            //    //}
            //}

            //host.Run();

            #endregion
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
