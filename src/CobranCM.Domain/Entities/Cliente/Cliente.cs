using CobranCM.Domain.ValueObjects;

namespace CobranCM.Domain.Entities
{
    public class Cliente
    {
        public int IDCliente { get; set; }
        public required string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public required EnderecoEmail Email { get; set; }
        public required string Documento { get; set; }
        public required string Telefone { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
