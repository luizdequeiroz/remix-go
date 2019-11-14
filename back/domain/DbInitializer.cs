using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace domain
{
    public static class DbInitializer
    {
        public static void InjectDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RemixGoContext>(options => options.UseMySQL(configuration.GetConnectionString("MySqlRemixGo"), b => b.MigrationsAssembly("api")), ServiceLifetime.Transient);
        }
    }
}
