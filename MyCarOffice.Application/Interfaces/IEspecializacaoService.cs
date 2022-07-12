using MyCarOffice.Application.DTOs;

namespace MyCarOffice.Application.Interfaces;

public interface IEspecializacaoService
{
    Task<IEnumerable<EspecializacaoDto>> GetAllAsync();
    Task<EspecializacaoDto> GetByIdAsync(Guid id);
    Task CreateAsync(EspecializacaoDto especializacaoDto);
    Task UpdateAsync(EspecializacaoDto especializacaoDto);
    Task RemoveAsync(EspecializacaoDto especializacaoDto);
}