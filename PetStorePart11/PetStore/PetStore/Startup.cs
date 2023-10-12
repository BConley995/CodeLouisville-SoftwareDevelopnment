using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using PetStore.Data;
using PetStore.Logic;


namespace PetStore 
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IProductLogic, ProductLogic>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context => {
                    await context.Response.WriteAsync("Hello From ASP.NET Core Web API");
                });
                endpoints.MapGet("/resource1", async context =>
                {
                    await context.Response.WriteAsync("Hello from ASP.NET Core Web APIT Resource1");
                });
            });
        }

    }
}
