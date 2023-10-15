using Elastic.Domain.Application;
using Elastic.Domain.Interfaces.Application;
using Microsoft.Extensions.DependencyInjection;

namespace Elastic.Core.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IActorsApplication, ActorsApplication>();
            return services;
        }
    }
}
