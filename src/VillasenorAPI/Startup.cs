using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Microsoft.Data.SqlClient;
using AutoMapper ;
using Newtonsoft.Json.Serialization;
using VillasenorAPI.Data.CityData;
using VillasenorAPI.Data;

namespace VillasenorAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get;}

        public Startup (IConfiguration configuration)
        {
            Configuration = configuration ; 
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = Configuration.GetConnectionString("VillaSenorConnection");
            builder.UserID = Configuration["User ID"];
            builder.Password = Configuration["Password"];
            
            services.AddDbContext<CityContext>(options =>
            options.UseSqlServer(builder.ConnectionString));
            services.AddDbContext<CustomerContext>(options =>
            options.UseSqlServer(builder.ConnectionString));
            
            services.AddControllers().AddNewtonsoftJson(s =>{
                s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<ICustomerAPIRepo , SqlCustomerAPIRepo>();
            services.AddScoped<ICityAPIRepo , SqlCityAPIRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
