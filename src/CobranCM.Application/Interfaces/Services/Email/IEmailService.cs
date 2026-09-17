using CobranCM.Domain.ValueObjects;

namespace CobranCM.Application.Common.Interfaces.Services
{
    public interface IEmailService
    {
        Task EnviarAsync(
            EnderecoEmail destinatario,
            string assunto,
            string corpo,
            CancellationToken cancellationToken = default);
    }
}