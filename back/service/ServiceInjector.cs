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
                .AddTransient<IGenericRepository<RMX>, GenericRepository<RMX>>()
                .AddTransient<IGenericRepository<MS>, GenericRepository<MS>>()
                .AddTransient<IGenericRepository<PlayerTable>, GenericRepository<PlayerTable>>();

            services.AddTransient<IGenericRepository<Armor>, GenericRepository<Armor>>()
                .AddTransient<IGenericRepository<Capabilitie>, GenericRepository<Capabilitie>>()
                .AddTransient<IGenericRepository<Disadvantage>, GenericRepository<Disadvantage>>()
                .AddTransient<IGenericRepository<EnhancedMove>, GenericRepository<EnhancedMove>>()
                .AddTransient<IGenericRepository<GenericAdvantage>, GenericRepository<GenericAdvantage>>()
                .AddTransient<IGenericRepository<Item>, GenericRepository<Item>>()
                .AddTransient<IGenericRepository<Practice>, GenericRepository<Practice>>()
                .AddTransient<IGenericRepository<PropertyAndRiche>, GenericRepository<PropertyAndRiche>>()
                .AddTransient<IGenericRepository<Skill>, GenericRepository<Skill>>()
                .AddTransient<IGenericRepository<Weapon>, GenericRepository<Weapon>>();

            services.AddTransient<IGenericRepository<SheetArmor>, GenericRepository<SheetArmor>>()
                .AddTransient<IGenericRepository<SheetCapabilitie>, GenericRepository<SheetCapabilitie>>()
                .AddTransient<IGenericRepository<SheetDisadvantage>, GenericRepository<SheetDisadvantage>>()
                .AddTransient<IGenericRepository<SheetEnhancedMove>, GenericRepository<SheetEnhancedMove>>()
                .AddTransient<IGenericRepository<SheetGenericAdvantage>, GenericRepository<SheetGenericAdvantage>>()
                .AddTransient<IGenericRepository<SheetItem>, GenericRepository<SheetItem>>()
                .AddTransient<IGenericRepository<SheetPractice>, GenericRepository<SheetPractice>>()
                .AddTransient<IGenericRepository<SheetPropertyAndRiche>, GenericRepository<SheetPropertyAndRiche>>()
                .AddTransient<IGenericRepository<SheetSkill>, GenericRepository<SheetSkill>>()
                .AddTransient<IGenericRepository<SheetWeapon>, GenericRepository<SheetWeapon>>();
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
