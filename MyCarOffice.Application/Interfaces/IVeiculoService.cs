using MyCarOffice.Application.DTOs.Commands.Create;
using MyCarOffice.Application.DTOs.Queries;

namespace MyCarOffice.Application.Interfaces;

public interface IVeiculoService
{
    Task<IEnumerable<VeiculoDto>> GetAllAsync();
    Task<VeiculoDto> GetByIdAsync(Guid id);
    Task<VeiculoDto> CreateAsync(VeiculoDtoCreateUpdate veiculoDto);
    Task<VeiculoDto> UpdateAsync(VeiculoDtoCreateUpdate veiculoDto);
    Task RemoveAsync(VeiculoDto veiculoDto);
}