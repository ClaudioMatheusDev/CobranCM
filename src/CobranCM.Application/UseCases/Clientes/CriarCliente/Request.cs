namespace CobranCM.Application.UseCases.Clientes.CriarCliente
{
    public class CriarClienteRequest
    {
        public required string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public required string Email { get; set; }
        public required string Documento { get; set; }
        public required string Telefone { get; set; }
    }
}
