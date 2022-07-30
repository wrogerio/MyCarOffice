using MyCarOffice.Application.DTOs.Commands.Create;
using MyCarOffice.Application.DTOs.Commands.Update;
using MyCarOffice.Application.DTOs.Queries;
using MyCarOffice.Application.DTOs.Queries.CleanDtos;

namespace MyCarOffice.Application.Interfaces;

public interface IClienteService
{
    Task<IEnumerable<ClienteDto>> GetAllAsync();
    Task<ClienteDto> GetByIdAsync(Guid id);
    Task<ClienteDtoClean> CreateAsync(ClienteDtoCreate clienteDto);
    Task<ClienteDtoClean> UpdateAsync(ClienteDtoUpdate clienteDto);
    Task RemoveAsync(ClienteDto clienteDto);
}