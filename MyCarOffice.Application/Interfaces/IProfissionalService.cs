using MyCarOffice.Application.DTOs;

namespace MyCarOffice.Application.Interfaces;

public interface IProfissionalService
{
    Task<IEnumerable<ProfissionalDto>> GetAllAsync();
    Task<ProfissionalDto> GetByIdAsync(Guid id);
    Task CreateAsync(ProfissionalDto profissionalDto);
    Task UpdateAsync(ProfissionalDto profissionalDto);
    Task RemoveAsync(ProfissionalDto profissionalDto);
}