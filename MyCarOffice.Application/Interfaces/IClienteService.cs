using MyCarOffice.Application.DTOs;
using MyCarOffice.Domain.Entities;

namespace MyCarOffice.Application.Interfaces;

public interface IClienteService
{
    Task<IEnumerable<ClienteDto>> GetAllAsync();
    Task<ClienteDto> GetByIdAsync(Guid id);
    Task CreateAsync(ClienteDto clienteDto);
    Task UpdateAsync(ClienteDto clienteDto);
    Task RemoveAsync(ClienteDto clienteDto);
}