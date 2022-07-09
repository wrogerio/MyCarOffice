namespace MyCarOffice.Domain.Entities
{
    public class Veiculo : EntityBase
    {
        public string Marca { get; set; } = "";
        public string Modelo { get; set; } = "";
        public string Placa { get; set; } = "";
        public int Ano { get; set; }
        public string Cor { get; set; } = "";
        public string Observacao { get; set; } = "";

        //Relacionamentos
        public Guid ClienteId { get; set; }
        public virtual Cliente? Cliente { get; set; }
    }
}
