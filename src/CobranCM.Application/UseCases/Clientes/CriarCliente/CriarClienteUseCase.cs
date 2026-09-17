using CobranCM.Application.Interfaces;
using CobranCM.Domain.Entities;
using CobranCM.Domain.ValueObjects;

namespace CobranCM.Application.UseCases.Clientes.CriarCliente;

public class CriarClienteUseCase
{
    private readonly IClienteRepository _clienteRepository;

    public CriarClienteUseCase(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public async Task<CriarClienteResponse> ExecutarAsync(
        CriarClienteRequest request,
        CancellationToken cancellationToken = default)
    {
        var cliente = new Cliente
        {
            Nome = request.Nome,
            DataNascimento = request.DataNascimento,
            Email = new EnderecoEmail(request.Email),
            Documento = request.Documento,
            Telefone = request.Telefone,
            DataCriacao = DateTime.UtcNow
        };

        await _clienteRepository.AdicionarClienteAsync(cliente, cancellationToken);

        return new CriarClienteResponse
        {
            IDCliente = cliente.IDCliente,
            Nome = cliente.Nome,
            Email = cliente.Email.Valor
        };
    }
}