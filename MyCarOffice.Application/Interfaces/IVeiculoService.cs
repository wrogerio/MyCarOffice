using MyCarOffice.Application.DTOs;

namespace MyCarOffice.Application.Interfaces
{
    public interface IVeiculoService
    {
        Task<IEnumerable<VeiculoDto>> GetAllAsync();
        Task<VeiculoDto> GetByIdAsync(Guid id);
        Task CreateAsync(VeiculoDto veiculoDto);
        Task UpdateAsync(VeiculoDto veiculoDto);
        Task RemoveAsync(VeiculoDto veiculoDto);
    }
}
