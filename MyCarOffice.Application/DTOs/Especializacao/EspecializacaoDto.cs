using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Application.DTOs.Especializacao;

public class EspecializacaoDto: EspecializacaoDtoClean
{
    public Guid ProfissionalId { get; set; }
    public string ProfissionalNome { get; set; } = "";
    public string ProfissionalCpf { get; set; } = "";
    public DateTime ProfissionalDataNasc { get; set; } = DateTime.Now;
    public AreaEnum ProfissionalArea { get; set; } = AreaEnum.Mecanica;
}