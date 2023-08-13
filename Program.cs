using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore; // Import the required namespace
using Pomelo.EntityFrameworkCore.MySql.Infrastructure; // Import the required namespace
using BlogApi.Data;
using BlogApi.Models;

namespace BlogApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
             CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureServices((hostContext, services) =>
                    {
                        services.AddDbContext<ApplicationDbContext>(options =>
                            options.UseMySql(hostContext.Configuration.GetConnectionString("MySqlConnection"),
                                 // Specify the MySQL version
                                 new MySqlServerVersion(new Version(8, 0, 27))));

                        services.AddControllers();
                        services.AddEndpointsApiExplorer();
                        services.AddSwaggerGen();
                    })
                    .Configure(app =>
                    {
                        var env = app.ApplicationServices.GetRequiredService<IWebHostEnvironment>();
                        if (env.IsDevelopment())
                        {
                            app.UseDeveloperExceptionPage();
                            app.UseSwagger();
                            app.UseSwaggerUI();
                        }
                        else
                        {
                            // Configure production error handling here
                        }

                        app.UseHttpsRedirection();
                        app.UseRouting(); // Add this line

                        app.UseAuthorization();

                        app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapControllers();
                        });
                    });
                });
    }
}
