using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Application.DTOs.Profissional;

public class ProfissionalDtoClean
{
    public Guid Id { get; set; }
    public string Nome { get; set; } = "";
    public string Cpf { get; set; } = "";
    public DateTime DataNasc { get; set; } = DateTime.Now;
    public AreaEnum Area { get; set; } = AreaEnum.Mecanica;
}