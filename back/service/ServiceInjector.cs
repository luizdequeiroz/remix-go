using domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using repository;
using repository.Interfaces;
using service.Utilities;
using static service.Utilities.TokenUtility;

namespace service
{
    public static class ServiceInjector
    {
        public static void InjectRepositories(this IServiceCollection services)
        {
            services.AddTransient<IGenericRepository<User>, GenericRepository<User>>()
                .AddTransient<IGenericRepository<Table>, GenericRepository<Table>>()
                .AddTransient<IGenericRepository<Card>, GenericRepository<Card>>();
        }

        public static void InjectAccessControllConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            var signinConfigurations = new SigningConfigurations();
            services.AddSingleton(signinConfigurations);

            var tokenConfiguration = new TokenConfigurations();
            new ConfigureFromConfigurationOptions<TokenConfigurations>(
                configuration.GetSection("TokenConfigurations")
            ).Configure(tokenConfiguration);

            services.AddSingleton(tokenConfiguration);
            services.AddAuthJwtConfigurations(signinConfigurations, tokenConfiguration);
        }

        public static void InjectUtilities(this IServiceCollection services)
        {
            services.AddTransient(typeof(CryptoUtility))
                .AddTransient(typeof(TokenUtility));
        }
    }
}
