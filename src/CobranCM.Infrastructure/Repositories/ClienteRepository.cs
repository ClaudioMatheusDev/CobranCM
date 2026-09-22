using CobranCM.Application.Interfaces;
using CobranCM.Domain.Entities;
using CobranCM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CobranCM.Infrastructure.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly ApplicationDbContext _context;

    public ClienteRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<Cliente?> BuscarClientePorIdAsync(int IDCliente, CancellationToken cancellationToken = default)
    {
        return _context.Clientes
            .FirstOrDefaultAsync(cliente => cliente.IDCliente == IDCliente, cancellationToken);
    }

    public Task<List<Cliente>> ListarClientesAsync(CancellationToken cancellationToken = default)
    {
        return _context.Clientes.ToListAsync(cancellationToken);
    }

    public async Task AdicionarClienteAsync(Cliente cliente, CancellationToken cancellationToken = default)
    {
        await _context.Clientes.AddAsync(cliente, cancellationToken);
        await SalvarAlteracoesAsync(cancellationToken);
    }

    public void Atualizar(Cliente cliente)
    {
        _context.Clientes.Update(cliente);
    }

    public void Remover(Cliente cliente)
    {
        _context.Clientes.Remove(cliente);
    }

    public Task SalvarAlteracoesAsync(CancellationToken cancellationToken = default)
    {
        return _context.SaveChangesAsync(cancellationToken);
    }
}
