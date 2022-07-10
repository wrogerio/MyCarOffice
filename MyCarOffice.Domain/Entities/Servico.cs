using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Domain.Entities;

public class Servico : EntityBase
{
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

    public AreaEnum Area { get; } = AreaEnum.Mecanica;
    public string Nome { get; } = "";
    public decimal Valor { get; }
    public DateTime TempoMedio { get; } = DateTime.Now;

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