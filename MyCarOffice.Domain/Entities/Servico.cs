using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Domain.Entities
{
    public class Servico : EntityBase
    {
        public AreaEnum Area { get; private set; } = AreaEnum.Mecanica;
        public string Nome { get; private set; } = "";
        public decimal Valor { get; private set; }
        public DateTime TempoMedio { get; private set; } = DateTime.Now;

        public Servico(AreaEnum area, string nome, decimal valor, DateTime tempoMedio)
        {
            if (Validar())
            {
                Area = area;
                Nome = nome;
                Valor = valor;
                TempoMedio = tempoMedio;
            }
        }

        private bool Validar()
        {
            // Área
            if (Area <= 0) return false;

            // Nome
            if (string.IsNullOrEmpty(Nome)) return false;

            // Valor 
            if (Valor <= 0) return false;

            // Tempo Médio
            if (TempoMedio.Equals(null)) return false;

            return true;
        }
    }
}
