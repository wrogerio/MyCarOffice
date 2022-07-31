using MyCarOffice.Application.DTOs.Veiculos;

namespace MyCarOffice.Application.DTOs.Clientes;

public class ClienteDto : ClienteDtoClean
{
    public virtual IEnumerable<VeiculoDtoClean>? Veiculos { get; set; }
}