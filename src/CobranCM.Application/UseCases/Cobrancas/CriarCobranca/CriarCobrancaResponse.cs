namespace CobranCM.Application.UseCases.Cobrancas.CriarCobranca
{
    public class CriarCobrancaResponse
{
    public int IDCobranca { get; set; }
    public int IDCliente { get; set; }
    public decimal ValorOriginal { get; set; }
    public DateTime DataVencimento { get; set; }
}
}
