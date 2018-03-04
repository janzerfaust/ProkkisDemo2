using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProkkisDemo2.Core;
using ProkkisDemo2.Persistance;
using ProkkisDemo2.Persistance.Mock;

namespace ProkkisDemo2
{
    public class Startup
    {
        public IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddEntityFrameworkNpgsql().AddDbContext<ProkkisDbContext>(
                options => options.UseNpgsql(
                    Configuration.GetConnectionString("ProkkisDbConnection")
                ));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
