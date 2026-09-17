namespace CobranCM.Domain.ValueObjects
{
    public class EnderecoEmail
    {
        public string Valor { get; private set; }

        public EnderecoEmail(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                throw new ArgumentException("E-mail obrigatorio.");

            if (!valor.Contains('@'))
                throw new ArgumentException("E-mail invalido.");

            Valor = valor.Trim().ToLower();
        }
    }
}
