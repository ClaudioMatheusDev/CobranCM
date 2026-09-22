using CobranCM.Application.UseCases.Clientes.CriarCliente;
using CobranCM.Application.UseCases.Cobrancas.CriarCobranca;
using Microsoft.Extensions.DependencyInjection;

namespace CobranCM.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<CriarClienteUseCase>();
        services.AddScoped<CriarCobrancaUseCase>();

        return services;
    }
}
