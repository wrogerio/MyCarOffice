using MyCarOffice.Application.DTOs.Commands.Create;
using MyCarOffice.Application.DTOs.Commands.Update;
using MyCarOffice.Application.DTOs.Queries;
using MyCarOffice.Application.DTOs.Queries.CleanDtos;

namespace MyCarOffice.Application.Interfaces;

public interface IClienteService
{
    Task<List<ClienteDto>> GetAllAsync();
    Task<ClienteDto> GetByIdAsync(Guid id);
    Task CreateAsync(ClienteDtoCreate clienteDto);
    Task UpdateAsync(ClienteDtoUpdate clienteDto);
    Task RemoveAsync(ClienteDto clienteDto);
}