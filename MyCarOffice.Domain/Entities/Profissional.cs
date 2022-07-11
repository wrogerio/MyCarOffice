using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Domain.Entities;

public class Profissional : EntityBase
{
    public Profissional(string nome, string cpf, DateTime dataNasc, AreaEnum area)
    {
        if (!Validar()) return;
        Nome = nome;
        Cpf = cpf;
        DataNasc = dataNasc;
        Area = area;
    }

    public string Nome { get; set; } = "";
    public string Cpf { get; set; } = "";
    public DateTime DataNasc { get; set; } = DateTime.Now;
    public AreaEnum Area { get; set; } = AreaEnum.Mecanica;

    //Relacionamentos
    public virtual IEnumerable<Especializacao>? Especializacoes { get; set; }


    private bool Validar()
    {
        // Nome
        if (string.IsNullOrEmpty(Nome)) return false;

        // CPF
        if (string.IsNullOrEmpty(Cpf)) return false;

        // DataNasc
        if (DataNasc.Equals(null)) return false;

        // Área
        if (Area <= 0) return false;

        return true;
    }
}