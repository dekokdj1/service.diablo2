using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Service.Diablo2.Database;
using Service.Diablo2.Extensions;

namespace Service.Diablo2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerDocument(document => {
                document.Title = "Diablo 2 Items Service";
            });
            services.AddDbContext<Diablo2Context>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Diablo2Context")));
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseOpenApi();
            app.UseRouting();
            app.UseSwaggerUi3();
            app.UseAuthorization();
            app.ConfigureExceptionHandler(app.ApplicationServices.GetService<ILogger>());
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
