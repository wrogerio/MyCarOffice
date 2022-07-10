using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Domain.Entities
{
    public class Profissional : EntityBase
    {
        public string Nome { get; private set; } = "";
        public string CPF { get; private set; } = "";
        public DateTime DataNasc { get; private set; } = DateTime.Now;
        public AreaEnum Area { get; private set; } = AreaEnum.Mecanica;

        //Relacionamentos
        public virtual IEnumerable<Especializacao>? Especializacoes { get; set; }

        public Profissional(string nome, string cPF, DateTime dataNasc, AreaEnum area)
        {
            if (Validar())
            {
                Nome = nome;
                CPF = cPF;
                DataNasc = dataNasc;
                Area = area;
            }
        }


        private bool Validar()
        {
            // Nome
            if (string.IsNullOrEmpty(Nome)) return false;

            // CPF
            if (string.IsNullOrEmpty(CPF)) return false;

            // DataNasc
            if (DataNasc.Equals(null)) return false;

            // Área
            if (Area <= 0) return false;

            return true;
        }
    }
}
