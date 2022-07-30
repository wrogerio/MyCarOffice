using MyCarOffice.Application.DTOs.Queries;

namespace MyCarOffice.Application.Interfaces;

public interface IEspecializacaoService
{
    Task<IEnumerable<EspecializacaoDto>> GetAllAsync();
    Task<EspecializacaoDto> GetByIdAsync(Guid id);
    Task<EspecializacaoDto> CreateAsync(EspecializacaoDto especializacaoDto);
    Task<EspecializacaoDto> UpdateAsync(EspecializacaoDto especializacaoDto);
    Task RemoveAsync(EspecializacaoDto especializacaoDto);
}