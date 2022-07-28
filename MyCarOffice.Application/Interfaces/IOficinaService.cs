using MyCarOffice.Application.DTOs;

namespace MyCarOffice.Application.Interfaces;

public interface IOficinaService
{
    Task<IEnumerable<OficinaDto>> GetAllAsync();
    Task<OficinaDto> GetByIdAsync(Guid id);
    Task<OficinaDto> CreateAsync(OficinaDto oficinaDto);
    Task<OficinaDto> UpdateAsync(OficinaDto oficinaDto);
    Task RemoveAsync(OficinaDto oficinaDto);
}