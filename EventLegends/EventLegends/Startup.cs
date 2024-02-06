using EventLegends.Data;
using EventLegends.Helpers.Extensions;
using EventLegends.Models.Enums;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace EventLegends
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

            // Adăugarea configurației bazei de date
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            // Adăugarea altor servicii și configurații
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddCategoryRepositories().AddCategoryServices();
            // Alte înregistrări de servicii...

            // Adăugarea politicii de autorizare pentru roluri
            services.AddAuthorization(options =>
            {
                foreach (var role in Enum.GetNames(typeof(Role)))
                {
                    options.AddPolicy(role, policy => policy.RequireRole(role));
                }
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EventLegends API v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

