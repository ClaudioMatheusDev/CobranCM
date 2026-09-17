using CobranCM.Domain.Entities;

namespace CobranCM.Application.Interfaces
{
    public interface IClienteRepository
    {
        Task<Cliente?> BuscarClientePorIdAsync(int IDCliente, CancellationToken cancellationToken = default);
        Task<List<Cliente>> ListarClientesAsync(CancellationToken cancellationToken = default);
        Task AdicionarClienteAsync(Cliente cliente, CancellationToken cancellationToken = default);
        void Atualizar(Cliente cliente);
        void Remover(Cliente cliente);
        Task SalvarAlteracoesAsync(CancellationToken cancellationToken = default);
    }
}
