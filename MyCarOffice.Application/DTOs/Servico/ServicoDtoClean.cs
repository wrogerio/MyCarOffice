using System.ComponentModel.DataAnnotations;
using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Application.DTOs.Servico;

public class ServicoDtoClean
{
    [Key] public Guid Id { get; set; }
    public string Nome { get; set; } = "";
    public AreaEnum Area { get; set; } = AreaEnum.Mecanica;
    public double Valor { get; set; }
    public double TempoMedio { get; set; } = 0d;
}