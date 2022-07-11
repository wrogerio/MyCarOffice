using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Domain.Entities;

public class Servico : EntityBase
{
    public Servico(AreaEnum area, string nome, decimal valor, DateTime tempoMedio)
    {
        if (!Validar()) return;
        Area = area;
        Nome = nome;
        Valor = valor;
        TempoMedio = tempoMedio;
    }

    public AreaEnum Area { get; set; } = AreaEnum.Mecanica;
    public string Nome { get; set; } = "";
    public decimal Valor { get; set; }
    public DateTime TempoMedio { get; set; } = DateTime.Now;

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