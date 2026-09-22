using CobranCM.Application.Interfaces;
using CobranCM.Domain.Entities;

namespace CobranCM.Application.UseCases.Cobrancas.CriarCobranca
{
    public class CriarCobrancaUseCase
    {
        private readonly ICobrancaRepository _cobrancaRepository;
        private readonly IClienteRepository _clienteRepository;

        public CriarCobrancaUseCase(
            ICobrancaRepository cobrancaRepository,
            IClienteRepository clienteRepository)
        {
            _cobrancaRepository = cobrancaRepository;
            _clienteRepository = clienteRepository;
        }

        public async Task<CriarCobrancaResponse> ExecutarAsync(
            CriarCobrancaRequest request,
            CancellationToken cancellationToken = default)
        {
            var cliente = await _clienteRepository.BuscarClientePorIdAsync(
                request.IDCliente,
                cancellationToken);

            if (cliente is null)
                throw new InvalidOperationException("Cliente nao encontrado.");

            var cobranca = new Cobranca
            {
                IDCliente = request.IDCliente,
                ValorOriginal = request.ValorOriginal,
                DataVencimento = request.DataVencimento,
                DataEmissao = DateTime.UtcNow
            };

            await _cobrancaRepository.AdicionarCobrancaAsync(cobranca, cancellationToken);

            return new CriarCobrancaResponse
            {
                IDCobranca = cobranca.IDCobranca,
                IDCliente = cobranca.IDCliente,
                ValorOriginal = cobranca.ValorOriginal,
                DataVencimento = cobranca.DataVencimento
            };
        }
    }
}
