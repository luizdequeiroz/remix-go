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

            services.AddTransient<IGenericRepository<Armor>, GenericRepository<Armor>>()
                .AddTransient<IGenericRepository<Capabilitie>, GenericRepository<Capabilitie>>()
                .AddTransient<IGenericRepository<Disadvantage>, GenericRepository<Disadvantage>>()
                .AddTransient<IGenericRepository<EnhancedMove>, GenericRepository<EnhancedMove>>()
                .AddTransient<IGenericRepository<Item>, GenericRepository<Item>>()
                .AddTransient<IGenericRepository<Practice>, GenericRepository<Practice>>()
                .AddTransient<IGenericRepository<PropertyAndRiche>, GenericRepository<PropertyAndRiche>>()
                .AddTransient<IGenericRepository<Skill>, GenericRepository<Skill>>()
                .AddTransient<IGenericRepository<Weapon>, GenericRepository<Weapon>>();

            services.AddTransient<IGenericRepository<CardArmor>, GenericRepository<CardArmor>>()
                .AddTransient<IGenericRepository<CardCapabilitie>, GenericRepository<CardCapabilitie>>()
                .AddTransient<IGenericRepository<CardDisadvantage>, GenericRepository<CardDisadvantage>>()
                .AddTransient<IGenericRepository<CardEnhancedMove>, GenericRepository<CardEnhancedMove>>()
                .AddTransient<IGenericRepository<CardItem>, GenericRepository<CardItem>>()
                .AddTransient<IGenericRepository<CardPractice>, GenericRepository<CardPractice>>()
                .AddTransient<IGenericRepository<CardPropertyAndRiche>, GenericRepository<CardPropertyAndRiche>>()
                .AddTransient<IGenericRepository<CardSkill>, GenericRepository<CardSkill>>()
                .AddTransient<IGenericRepository<CardWeapon>, GenericRepository<CardWeapon>>();
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
