using domain;
using domain.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using repository;
using repository.Interfaces;
using service;
using service.Interfaces;
using Swashbuckle.AspNetCore.Swagger;
using System.Diagnostics;
using System.Reflection;

namespace api
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
            services.AddCors(
                options => options.AddPolicy(
                    "AllowAll", p =>
                    {
                        p.AllowAnyOrigin();
                        p.AllowAnyMethod();
                        p.AllowAnyHeader();
                    }));

            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory("AllowAll"));
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IGenericRepository<User>, GenericRepository<User>>();

            services.InjectDbContext(Configuration);

            var version = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(version, new Info
                {
                    Title = Configuration.GetValue<string>("api_name"),
                    Version = version
                });
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("AllowAll");

            if (Configuration.GetValue<string>("Ambiente") != "P")
            {
                app.UseDeveloperExceptionPage();

                var routePrefix = string.Empty;
#if RELEASE
                routePrefix = $"/{Configuration.GetValue<string>("RoutePrefix")}";
#endif
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    var version = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
                    c.SwaggerEndpoint($"{routePrefix}/swagger/{version}/swagger.json", Configuration.GetValue<string>("api_name"));
                    c.RoutePrefix = "swagger";
                });

                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
