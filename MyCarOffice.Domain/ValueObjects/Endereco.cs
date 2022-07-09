
namespace MyCarOffice.Domain.ValueObjects
{
    public class Endereco
    {
        public string Logradouro { get; set; } = "";
        public int Numero { get; set; }
        public string Bairro { get; set; } = "";
        public string CEP { get; set; } = "";
    }
}
