using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;

namespace Elastic.Core.Extensions
{
    public static class ElasticSearchExtensions
    {
        public static IServiceCollection AddElasticSearch(this IServiceCollection services, IConfiguration configuration)
        {
            var uri = configuration["ElasticsearchSettings:uri"] ?? string.Empty;
            var settings = new ConnectionSettings(new Uri(uri));
            var defaultIndex = configuration["ElasticsearchSettings:defaultIndex"];
            var basicAuthUser = configuration["ElasticsearchSettings:username"];
            var basicAuthPassword = configuration["ElasticsearchSettings:password"];

            if (!string.IsNullOrEmpty(defaultIndex))
                settings = settings.DefaultIndex(defaultIndex);

            if (!string.IsNullOrEmpty(basicAuthUser) && !string.IsNullOrEmpty(basicAuthPassword))
                settings = settings.BasicAuthentication(basicAuthUser, basicAuthPassword);

            var client = new ElasticClient(settings);

            services.AddSingleton<IElasticClient>(client);
            return services;
        }
    }
}
