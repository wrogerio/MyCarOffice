using MyCarOffice.Application.DTOs;

namespace MyCarOffice.Application.Interfaces;

public interface IClienteService
{
    Task<IEnumerable<ClienteDto>> GetAllAsync();
    Task<ClienteDto> GetByIdAsync(Guid id);
    Task CreateAsync(ClienteDto clienteDto);
    Task UpdateAsync(ClienteDto clienteDto);
    Task RemoveAsync(ClienteDto clienteDto);
}