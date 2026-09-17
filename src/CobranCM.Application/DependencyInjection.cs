using Microsoft.Extensions.DependencyInjection;

namespace CobranCM.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}
