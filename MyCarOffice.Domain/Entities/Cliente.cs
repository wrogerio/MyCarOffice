using MyCarOffice.Domain.ValueObjects;

namespace MyCarOffice.Domain.Entities
{
    public class Cliente : EntityBase
    {
        public string Nome { get; set; } = "";
        public string CPF { get; set; } = "";
        public DateTime DataNasc { get; set; } = DateTime.Now;
        public string Email { get; set; } = "";
        public string Sexo { get; set; } = "";
        public Endereco? Endereco { get; set; }
        public string Telefone { get; set; } = "";

        //Relacionamentos
        public virtual IEnumerable<Veiculo>? Veiculos { get; set; }
    }
}
