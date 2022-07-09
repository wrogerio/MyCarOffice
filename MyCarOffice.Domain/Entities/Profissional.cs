using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Domain.Entities
{
    public class Profissional : EntityBase
    {
        public string Nome { get; set; } = "";
        public string CPF { get; set; } = "";
        public DateTime DataNasc { get; set; } = DateTime.Now;
        public AreaEnum Area { get; set; } = AreaEnum.Mecanica;

        //Relacionamentos
        public virtual IEnumerable<Especializacao>? Especializacoes { get; set; }
    }
}
