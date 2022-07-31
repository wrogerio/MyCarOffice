using MyCarOffice.Application.DTOs.Servico;

namespace MyCarOffice.Application.Interfaces;

public interface IServicoService
{
    Task<List<ServicoDto>> GetAllAsync();
    Task<ServicoDto> GetByIdAsync(Guid id);
    Task CreateAsync(ServicoDtoCreate servicoDto);
    Task UpdateAsync(ServicoDtoUpdate servicoDto);
    Task RemoveAsync(ServicoDto servicoDto);
}