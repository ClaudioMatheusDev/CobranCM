namespace CobranCM.Domain.Entities
{
    public class Cobranca
    {
        public int IDCobranca { get; set; }
        public required int IDCliente { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal? ValorPago { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? JurosMulta { get; set; }
        public DateTime DataEmissao { get; set; } = DateTime.UtcNow;
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
    }
}
