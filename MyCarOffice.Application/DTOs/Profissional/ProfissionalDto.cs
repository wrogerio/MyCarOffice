using MyCarOffice.Application.DTOs.Especializacao;

namespace MyCarOffice.Application.DTOs.Profissional;

public class ProfissionalDto : ProfissionalDtoClean
{
    public virtual IEnumerable<EspecializacaoDtoClean>? Especializacoes { get; set; }
}