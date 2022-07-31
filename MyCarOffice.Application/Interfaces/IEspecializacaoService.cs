using MyCarOffice.Application.DTOs.Especializacao;

namespace MyCarOffice.Application.Interfaces;

public interface IEspecializacaoService
{
    Task<List<EspecializacaoDto>> GetAllAsync();
    Task<EspecializacaoDto> GetByIdAsync(Guid id);
    Task CreateAsync(EspecializacaoDtoCreate especializacaoDto);
    Task UpdateAsync(EspecializacaoDtoUpdate especializacaoDto);
    Task RemoveAsync(EspecializacaoDto especializacaoDto);
}