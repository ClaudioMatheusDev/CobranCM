using CobranCM.Application.UseCases.Clientes.CriarCliente;
using Microsoft.AspNetCore.Mvc;

namespace CobranCM.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private readonly CriarClienteUseCase _criarClienteUseCase;

    public ClientesController(CriarClienteUseCase criarClienteUseCase)
    {
        _criarClienteUseCase = criarClienteUseCase;
    }

    [HttpPost]
    public async Task<ActionResult<CriarClienteResponse>> CriarCliente(
        CriarClienteRequest request,
        CancellationToken cancellationToken)
    {
        var response = await _criarClienteUseCase.ExecutarAsync(request, cancellationToken);

        return CreatedAtAction(nameof(CriarCliente), new { id = response.IDCliente }, response);
    }
}
