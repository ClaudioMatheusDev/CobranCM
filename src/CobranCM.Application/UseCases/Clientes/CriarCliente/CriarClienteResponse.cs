namespace CobranCM.Application.UseCases.Clientes.CriarCliente
{
    public class CriarClienteResponse
    {
        public int IDCliente { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
    }
}
