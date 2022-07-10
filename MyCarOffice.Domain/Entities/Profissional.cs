using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Domain.Entities;

public class Profissional : EntityBase
{
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

    public string Nome { get; } = "";
    public string CPF { get; } = "";
    public DateTime DataNasc { get; } = DateTime.Now;
    public AreaEnum Area { get; } = AreaEnum.Mecanica;

    //Relacionamentos
    public virtual IEnumerable<Especializacao>? Especializacoes { get; set; }


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