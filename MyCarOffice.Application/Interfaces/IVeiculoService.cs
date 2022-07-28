using MyCarOffice.Application.DTOs;

namespace MyCarOffice.Application.Interfaces;

public interface IVeiculoService
{
    Task<IEnumerable<VeiculoDto>> GetAllAsync();
    Task<VeiculoDto> GetByIdAsync(Guid id);
    Task<VeiculoDto> CreateAsync(VeiculoDto veiculoDto);
    Task<VeiculoDto> UpdateAsync(VeiculoDto veiculoDto);
    Task RemoveAsync(VeiculoDto veiculoDto);
}