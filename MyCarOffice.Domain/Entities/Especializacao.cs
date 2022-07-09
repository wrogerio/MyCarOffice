namespace MyCarOffice.Domain.Entities
{
    public class Especializacao : EntityBase
    {
        public string Nome { get; set; } = "";
        public DateTime Since { get; set; } = DateTime.Now;


        //Relacionamentos
        public int ProfissionalId { get; set; }
        public virtual Profissional? Profissional { get; set; }
    }
}
