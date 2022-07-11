using MyCarOffice.Application.DTOs;

namespace MyCarOffice.Application.Interfaces
{
    public interface IServicoService
    {
        Task<IEnumerable<ServicoDto>> GetAllAsync();
        Task<ServicoDto> GetByIdAsync(Guid id);
        Task CreateAsync(ServicoDto servicoDto);
        Task UpdateAsync(ServicoDto servicoDto);
        Task RemoveAsync(ServicoDto servicoDto);
    }
}
