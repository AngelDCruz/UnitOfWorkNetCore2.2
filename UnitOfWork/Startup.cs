using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Datos.Datos;
using App.Datos.Repository;
using App.Repository;
using App.Repository.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<DatosDbContext>(config =>
            {

                config.UseSqlServer(Configuration.GetConnectionString("SqlServer"));

            });

            services.AddIdentity<IdentityUser, IdentityRole>(opciones =>
            {
                opciones.Password.RequireDigit = false;
                opciones.Password.RequireNonAlphanumeric = false;
                opciones.Password.RequireUppercase = false;
                opciones.Password.RequireLowercase = false;

            })
            .AddEntityFrameworkStores<DatosDbContext>()
            .AddDefaultTokenProviders();

            services.AddScoped(typeof(Unit));
            services.AddScoped(typeof(IRepository<>) , typeof(GenericRepository<>));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
