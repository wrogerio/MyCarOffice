using MyCarOffice.Application.DTOs;

namespace MyCarOffice.Application.Interfaces;

public interface IProfissionalService
{
    Task<IEnumerable<ProfissionalDto>> GetAllAsync();
    Task<ProfissionalDto> GetByIdAsync(Guid id);
    Task<ProfissionalDto> CreateAsync(ProfissionalDto profissionalDto);
    Task<ProfissionalDto> UpdateAsync(ProfissionalDto profissionalDto);
    Task RemoveAsync(ProfissionalDto profissionalDto);
}