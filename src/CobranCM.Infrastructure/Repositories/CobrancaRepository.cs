using CobranCM.Application.Interfaces;
using CobranCM.Domain.Entities;
using CobranCM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CobranCM.Infrastructure.Repositories;

public class CobrancaRepository : ICobrancaRepository
{
    private readonly ApplicationDbContext _context;

    public CobrancaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<Cobranca?> BuscarCobrancaPorIdAsync(int IDCobranca, CancellationToken cancellationToken = default)
    {
        return _context.Cobrancas
            .FirstOrDefaultAsync(cobranca => cobranca.IDCobranca == IDCobranca, cancellationToken);
    }

    public Task<List<Cobranca>> ListarCobrancasAsync(CancellationToken cancellationToken = default)
    {
        return _context.Cobrancas.ToListAsync(cancellationToken);
    }

    public async Task AdicionarCobrancaAsync(Cobranca cobranca, CancellationToken cancellationToken = default)
    {
        await _context.Cobrancas.AddAsync(cobranca, cancellationToken);
        await SalvarAlteracoesAsync(cancellationToken);
    }

    public void Atualizar(Cobranca cobranca)
    {
        _context.Cobrancas.Update(cobranca);
    }

    public void Remover(Cobranca cobranca)
    {
        _context.Cobrancas.Remove(cobranca);
    }

    public Task SalvarAlteracoesAsync(CancellationToken cancellationToken = default)
    {
        return _context.SaveChangesAsync(cancellationToken);
    }
}
