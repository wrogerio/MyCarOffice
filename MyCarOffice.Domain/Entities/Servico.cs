using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Domain.Entities
{
    public class Servico : EntityBase
    {
        public AreaEnum Area { get; set; } = AreaEnum.Mecanica;
        public string Nome { get; set; } = "";
        public decimal Valor { get; set; }
        public DateTime TempoMedio { get; set; } = DateTime.Now;
    }
}
