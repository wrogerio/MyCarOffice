using MyCarOffice.Application.DTOs.OrdemDeServico;

namespace MyCarOffice.Application.Interfaces;

public interface IOrdemDeServicoService
{
    Task<List<OrdemDeServicoDto>> GetAllAsync();
    Task<OrdemDeServicoDto> GetByIdAsync(Guid id);
    Task CreateAsync(OrdemDeServicoDtoCreate ordemDeServicoDto);
    Task UpdateAsync(OrdemDeServicoDtoUpdate ordemDeServicoDto);
    Task RemoveAsync(OrdemDeServicoDto ordemDeServicoDto);
}