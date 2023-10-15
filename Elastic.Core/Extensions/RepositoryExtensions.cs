using Elastic.Domain.Interfaces.Repository;
using Elastic.Domain.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Elastic.Core.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IActorsRepository, ActorsRepository>();
            return services;
        }
    }
}
