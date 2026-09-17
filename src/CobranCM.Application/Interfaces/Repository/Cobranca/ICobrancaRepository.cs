using CobranCM.Domain.Entities;

namespace CobranCM.Application.Interfaces
{
    public interface ICobrancaRepository
    {
        Task<Cobranca?> BuscarCobrancaPorIdAsync(int IDCobranca, CancellationToken cancellationToken = default);
        Task<List<Cobranca>> ListarCobrancasAsync(CancellationToken cancellationToken = default);
        Task AdicionarCobrancaAsync(Cobranca cobranca, CancellationToken cancellationToken = default);
        void Atualizar(Cobranca cobranca);
        void Remover(Cobranca cobranca);
        Task SalvarAlteracoesAsync(CancellationToken cancellationToken = default);
    }
}
