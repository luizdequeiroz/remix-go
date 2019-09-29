using domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using repository;
using repository.Interfaces;

namespace service
{
    public static class ServiceInjector
    {
        public static void InjectRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IGenericRepository<User>, GenericRepository<User>>();
        }
    }
}
