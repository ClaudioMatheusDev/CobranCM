using CobranCM.Domain.Enums;

namespace CobranCM.Domain.Entities
{
    public class Parcela
    {
        public int IDParcela { get; set; }
        public int IDCobranca { get; set; }
        public int Numero { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal? ValorPago { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public StatusParcela Status { get; set; }
    }
}
