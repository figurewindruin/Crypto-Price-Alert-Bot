using CryptoPriceAlertBot.Core.Events;
using CryptoPriceAlertBot.Core.Pipelines;
using CryptoPriceAlertBot.Infrastructure.Events;
using CryptoPriceAlertBot.Infrastructure.Metrics;
using CryptoPriceAlertBot.Infrastructure.Persistence;
using CryptoPriceAlertBot.Infrastructure.Validation;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoPriceAlertBot.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton(typeof(IJsonRepository<>), typeof(JsonRepository<>));
            services.AddSingleton<IRequestValidator<object>, DefaultRequestValidator<object>>();
            services.AddSingleton<IMetricsPublisher, ConsoleMetricsPublisher>();
            services.AddSingleton<IDomainEventBus, InMemoryDomainEventBus>();
            services.AddSingleton(typeof(IPipelineBehavior<,>), typeof(LoggingPipelineBehavior<,>));
            return services;
        }
    }
}
