using MyCarOffice.Application.DTOs.Oficina;

namespace MyCarOffice.Application.Interfaces;

public interface IOficinaService
{
    Task<List<OficinaDto>> GetAllAsync();
    Task<OficinaDto> GetByIdAsync(Guid id);
    Task CreateAsync(OficinaDtoCreate oficinaDto);
    Task UpdateAsync(OficinaDtoUpdate oficinaDto);
    Task RemoveAsync(OficinaDto oficinaDto);
}