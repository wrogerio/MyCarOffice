using MyCarOffice.Application.DTOs.Commands.Create;
using MyCarOffice.Application.DTOs.Veiculos;

namespace MyCarOffice.Application.Interfaces;

public interface IVeiculoService
{
    Task<IEnumerable<VeiculoDto>> GetAllAsync();
    Task<VeiculoDto> GetByIdAsync(Guid id);
    Task CreateAsync(VeiculoDtoCreate veiculoDto);
    Task UpdateAsync(VeiculoDtoUpdate veiculoDto);
    Task RemoveAsync(VeiculoDto veiculoDto);
}