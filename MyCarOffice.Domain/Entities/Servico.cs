using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Domain.Entities;

public class Servico : EntityBase
{
    public Servico(AreaEnum area, string nome, double valor, double tempoMedio)
    {
        if (!Validar()) return;
        Area = area;
        Nome = nome;
        Valor = valor;
        TempoMedio = tempoMedio;
    }

    public string Nome { get; set; } = "";
    public AreaEnum Area { get; set; } = AreaEnum.Mecanica;
    public double Valor { get; set; }
    public double TempoMedio { get; set; }

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