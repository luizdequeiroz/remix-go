using domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using service;
using service.Interfaces;
using service.Utilities;
using service.Utilities.Interfaces;
using Swashbuckle.AspNetCore.Swagger;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .ConfigureApiBehaviorOptions(options =>
                {
                    options.InvalidModelStateResponseFactory = context =>
                    {
                        return Controllers.Treatments.Returns.Info(context.ModelState, "Preencha as informações obrigatórias e corretamente.");
                    };
                });

            var version = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(version, new Info
                {
                    Title = Configuration.GetValue<string>("api_name"),
                    Version = version
                });
                c.AddSecurityDefinition("Bearer",
                    new ApiKeyScheme
                    {
                        In = "header",
                        Description = "Insira o token de uma sessão válida.",
                        Name = "Authorization",
                        Type = "apiKey"
                    }
                );
                c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>
                {
                    { "Bearer", Enumerable.Empty<string>() }
                });
                c.DescribeAllEnumsAsStrings();
            });

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITableService, TableService>();
            services.AddTransient<IRMXService, RMXService>();
            services.AddTransient<IMSService, MSService>();
            services.AddTransient<IPlayerTableService, PlayerTableService>();

            services.AddTransient<IArmorService, ArmorService>();
            services.AddTransient<ICapabilitieService, CapabilitieService>();
            services.AddTransient<IDisadvantageService, DisadvantageService>();
            services.AddTransient<IEnhancedMoveService, EnhancedMoveService>();
            services.AddTransient<IGenericAdvantageService, GenericAdvantageService>();
            services.AddTransient<IItemService, ItemService>();
            services.AddTransient<IPracticeService, PracticeService>();
            services.AddTransient<IPropertyAndRicheService, PropertyAndRicheService>();
            services.AddTransient<ISkillService, SkillService>();
            services.AddTransient<IWeaponService, WeaponService>();

            services.AddTransient<ISheetArmorService, SheetArmorService>();
            services.AddTransient<ISheetCapabilitieService, SheetCapabilitieService>();
            services.AddTransient<ISheetDisadvantageService, SheetDisadvantageService>();
            services.AddTransient<ISheetEnhancedMoveService, SheetEnhancedMoveService>();
            services.AddTransient<ISheetGenericAdvantageService, SheetGenericAdvantageService>();
            services.AddTransient<ISheetItemService, SheetItemService>();
            services.AddTransient<ISheetPracticeService, SheetPracticeService>();
            services.AddTransient<ISheetPropertyAndRicheService, SheetPropertyAndRicheService>();
            services.AddTransient<ISheetSkillService, SheetSkillService>();
            services.AddTransient<ISheetWeaponService, SheetWeaponService>();

            services.AddTransient<IServiceSwitch, ServiceSwitch>();

            services.InjectRepositories();
            services.InjectAccessControllConfigurations(Configuration);
            services.InjectUtilities();

            services.InjectDbContext(Configuration);
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
