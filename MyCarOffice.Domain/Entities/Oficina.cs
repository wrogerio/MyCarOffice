using MyCarOffice.Domain.ValueObjects;

namespace MyCarOffice.Domain.Entities
{
    public class Oficina : EntityBase
    {
        public string NomeFantasia { get; set; } = "";
        public string CNPJ { get; set; } = "";
        public string NomeResponsavel { get; set; } = "";
        public string Telefone { get; set; } = "";
        public string Email { get; set; } = "";
        public string Site { get; set; } = "";
        public Endereco? Endereco { get; set; }
    }
}
