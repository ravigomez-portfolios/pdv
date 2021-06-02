using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using POS.Backend.Data;
using POS.Backend.Models;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace backend_dotnet
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

            services.AddDbContext<Context>(opt => opt.UseSqlServer(Configuration.GetConnectionString("DBConnetion")));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(opt =>
                {
                    opt.Audience = Configuration["AAD:ResourceId"];
                    opt.Authority = $"{Configuration["AAD:Instance"]}{Configuration["AAD:TenantId"]}";
                });
            services.AddControllers()
                    .AddNewtonsoftJson(s => {s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();});
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { 
                    Title = "backend_dotnet", 
                    Version = "v1",
                    Description = "The backend of POS sample app",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Rafael Gómez",
                        Email = "ravigomez@gmail.com",
                        Url = new Uri("https://twitter.com/ravigomez"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT",
                        Url = new Uri("https://opensource.org/licenses/MIT"),
                    } 
                });
            });

            services.AddScoped<IRepository<Product>, ProductRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "backend_dotnet v1"));
            }

            app.UseHttpsRedirection();
            
            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
