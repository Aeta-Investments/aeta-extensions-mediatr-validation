using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Aeta.Extensions.Mediatr.Validation
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRequestValidationBehavior(
            this IServiceCollection services,
            ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
        {
            var serviceDescriptor = new ServiceDescriptor(typeof(IPipelineBehavior<,>),
                typeof(RequestValidationBehavior<,>), serviceLifetime);

            services.Add(serviceDescriptor);
            
            return services;
        }
    }
}