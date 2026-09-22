namespace CobranCM.Application.UseCases.Cobrancas.CriarCobranca
{
public class CriarCobrancaRequest
{
    public int IDCliente { get; set; }
    public decimal ValorOriginal { get; set; }
    public DateTime DataVencimento { get; set; }
}
}