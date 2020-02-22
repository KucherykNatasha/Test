using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestTask.Models;
using TestTask.Models.Observer;
namespace TestTask
{
    public class Startup
    {
        IConfiguration Configuration { get; }
        public Startup(IConfiguration config) => Configuration = config;
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<JsonOriginal, JsonOriginal>();
            services.AddTransient<JsonUpdate, JsonUpdate>();
            services.AddTransient<JsonBox, JsonBox>();
            services.AddTransient<Comparator, Comparator>();
            services.AddMvc();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
