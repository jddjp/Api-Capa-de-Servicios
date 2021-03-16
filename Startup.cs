using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
//SWagger 
using Microsoft.OpenApi.Models;

namespace Api_Capa_de_Servicios
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
            services.AddControllers();
            //Swagger 
            AddSwagger(services);
        }
        //Swagger
        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
              

                options.SwaggerDoc("Services", new OpenApiInfo
                {
                  
                    Title = "Servicios Integracion",
                    Version = "V1",
                    Description = "Esta Api Permite a los usuarios externos e internos poder realizar los diferentes procesos de Negocio de Aprecia mediante los métodos disponibles en la misma",
                    Contact = new OpenApiContact
                    {
                        Name = "Fomepade",
                        Email = string.Empty,
                       // Url = new Uri("https://foo.com/"),
                    }
                });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);

            });
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Swagger para  personalizar 
            app.UseStaticFiles();
            //Swagger
            app.UseSwagger();

           
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("Services/swagger.json", "Api Servicios Integracion");
               
                c.InjectStylesheet("/Swagger/Ui/custom.css");
               // c.InjectJavascript("/swagger-ui/custom.js");
            });

            //Swagger
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
