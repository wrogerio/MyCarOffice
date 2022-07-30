using MyCarOffice.Application.DTOs.Queries.CleanDtos;
using MyCarOffice.Application.DTOs.Veiculos;

namespace MyCarOffice.Application.DTOs.Queries;

public class ClienteDto : ClienteDtoClean
{
    public virtual IEnumerable<VeiculoDtoClean>? Veiculos { get; set; }
}