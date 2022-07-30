using MyCarOffice.Application.DTOs.Clientes;

namespace MyCarOffice.Application.Interfaces;

public interface IClienteService
{
    Task<List<ClienteDto>> GetAllAsync();
    Task<ClienteDto> GetByIdAsync(Guid id);
    Task CreateAsync(ClienteDtoCreate clienteDto);
    Task UpdateAsync(ClienteDtoUpdate clienteDto);
    Task RemoveAsync(ClienteDto clienteDto);
}