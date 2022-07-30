using MyCarOffice.Application.DTOs.Queries;

namespace MyCarOffice.Application.Interfaces;

public interface IServicoService
{
    Task<IEnumerable<ServicoDto>> GetAllAsync();
    Task<ServicoDto> GetByIdAsync(Guid id);
    Task<ServicoDto> CreateAsync(ServicoDto servicoDto);
    Task<ServicoDto> UpdateAsync(ServicoDto servicoDto);
    Task RemoveAsync(ServicoDto servicoDto);
}