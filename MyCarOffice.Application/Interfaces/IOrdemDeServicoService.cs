using MyCarOffice.Application.DTOs;

namespace MyCarOffice.Application.Interfaces;

public interface IOrdemDeServicoService
{
    Task<IEnumerable<OrdemDeServicoDto>> GetAllAsync();
    Task<OrdemDeServicoDto> GetByIdAsync(Guid id);
    Task<OrdemDeServicoDto> CreateAsync(OrdemDeServicoDto ordemDeServicoDto);
    Task<OrdemDeServicoDto> UpdateAsync(OrdemDeServicoDto ordemDeServicoDto);
    Task RemoveAsync(OrdemDeServicoDto ordemDeServicoDto);
}