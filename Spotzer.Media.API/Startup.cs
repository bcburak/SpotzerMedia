using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using FluentValidation.AspNetCore;
using Spotzer.Media.Application.Validations;
using FluentValidation;

namespace Spotzer.Media.API
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
            services.AddMvcCore().AddApiExplorer();
            //services.AddMvc().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<PartnerAValidator>());
            //services.AddMvc().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<PartnerCValidator>());

            services.AddSingleton<IValidator, PartnerAValidator>();
            services.AddSingleton<IValidator, PartnerCValidator>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Spotzer.Media.API", Version = "v1" });
            });
            
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();               
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Spotzer.Media.API v1"));
            app.UseRouting();


            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    var logger = appError.ApplicationServices.GetRequiredService<ILogger<Startup>>();
                    var exception = context.Features.Get<IExceptionHandlerFeature>();

                    if(exception.Error != null)
                    {
                        logger.LogError(exception.Error, "Exception Here");
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        context.Response.ContentType = "application/json";
                        await context.Response.WriteAsync(System.Text.Json.JsonSerializer.Serialize(new
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = "Internal Server Error. "
                        }));
                    }                  

                });
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
 

        }
    }
}
