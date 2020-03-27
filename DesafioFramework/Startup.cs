using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DesafioFramework.Bll.Abstract;
using DesafioFramework.Bll.Concrete;
using DesafioFramework.Bll.mapping;
using DesafioFramework.Dal;
using DesafioFramework.Dal.Abstract;
using DesafioFramework.Dal.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DesafioFramework
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddTransient<IPacienteDal, PacienteDal>();
            services.AddTransient<IEstadoDal, EstadoDal>();
            services.AddTransient<ICidadeDal, CidadeDal>();
            services.AddTransient<IPaisDal, PaisDal>();
            services.AddTransient(typeof(IBaseDal<>), typeof(BaseDal<>));

            services.AddTransient<IPacienteBll, PacienteBll>();
            services.AddTransient<IEstadoBll, EstadoBll>();
            services.AddTransient<ICidadeBll, CidadeBll>();
            services.AddTransient<IPaisBll, PaisBll>();
            services.AddTransient(typeof(IBaseBll<,,>), typeof(BaseBll<,,>));

            services.AddTransient<IConnectionDb, ConnectionDb>();

            ConnStringGetter.Connstring = Configuration.GetSection("Database")["ConnectionString"];

            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
