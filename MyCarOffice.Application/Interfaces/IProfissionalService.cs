using MyCarOffice.Application.DTOs.Profissional;

namespace MyCarOffice.Application.Interfaces;

public interface IProfissionalService
{
    Task<List<ProfissionalDto>> GetAllAsync();
    Task<ProfissionalDto> GetByIdAsync(Guid id);
    Task CreateAsync(ProfissionalDtoCreate profissionalDto);
    Task UpdateAsync(ProfissionalDtoUpdate profissionalDto);
    Task RemoveAsync(ProfissionalDto profissionalDto);
}