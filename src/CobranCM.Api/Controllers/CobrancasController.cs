using CobranCM.Application.UseCases.Cobrancas.CriarCobranca;
using Microsoft.AspNetCore.Mvc;

namespace CobranCM.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CobrancasController : ControllerBase
{
    private readonly CriarCobrancaUseCase _criarCobrancaUseCase;

    public CobrancasController(CriarCobrancaUseCase criarCobrancaUseCase)
    {
        _criarCobrancaUseCase = criarCobrancaUseCase;
    }

    [HttpPost]
    public async Task<ActionResult<CriarCobrancaResponse>> CriarCobranca(
        CriarCobrancaRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var response = await _criarCobrancaUseCase.ExecutarAsync(request, cancellationToken);

            return CreatedAtAction(nameof(CriarCobranca), new { id = response.IDCobranca }, response);
        }
        catch (InvalidOperationException exception)
        {
            return BadRequest(new { message = exception.Message });
        }
    }
}
