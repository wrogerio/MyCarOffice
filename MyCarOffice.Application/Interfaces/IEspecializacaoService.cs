using MyCarOffice.Application.DTOs;
using MyCarOffice.Domain.Entities;

namespace MyCarOffice.Application.Interfaces;

public interface IEspecializacaoService
{
    Task<IEnumerable<EspecializacaoDto>> GetAllAsync();
    Task<EspecializacaoDto> GetByIdAsync(Guid id);
    Task<EspecializacaoDto> CreateAsync(EspecializacaoDto especializacaoDto);
    Task<EspecializacaoDto> UpdateAsync(EspecializacaoDto especializacaoDto);
    Task RemoveAsync(EspecializacaoDto especializacaoDto);
}