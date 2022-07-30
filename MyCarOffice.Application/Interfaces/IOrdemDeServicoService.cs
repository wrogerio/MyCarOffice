using MyCarOffice.Application.DTOs.Queries;

namespace MyCarOffice.Application.Interfaces;

public interface IOrdemDeServicoService
{
    Task<IEnumerable<OrdemDeServicoDto>> GetAllAsync();
    Task<OrdemDeServicoDto> GetByIdAsync(Guid id);
    Task CreateAsync(OrdemDeServicoDto ordemDeServicoDto);
    Task UpdateAsync(OrdemDeServicoDto ordemDeServicoDto);
    Task RemoveAsync(OrdemDeServicoDto ordemDeServicoDto);
}