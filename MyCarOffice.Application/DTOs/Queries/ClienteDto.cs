using MyCarOffice.Application.DTOs.Queries.CleanDtos;

namespace MyCarOffice.Application.DTOs.Queries;

public class ClienteDto: ClienteDtoClean
{
    public virtual IEnumerable<VeiculoDtoClean>? Veiculos { get; set; }
}