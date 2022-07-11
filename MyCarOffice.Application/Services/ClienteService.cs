using AutoMapper;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Application.Mapping;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services;

public class ClienteService : IClienteService
{
    private readonly IClienteRepository _repository;
    private readonly IMapper _mapper;

    public ClienteService(IClienteRepository repository, IMapper mapper)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<IEnumerable<ClienteDto>> GetAllAsync()
    {
        var clientes = await _repository.GetAllAsync();
        var clientesDto = _mapper.Map<IEnumerable<ClienteDto>>(clientes);
        return clientesDto;
    }

    public async Task<ClienteDto> GetByIdAsync(Guid id)
    {
        var cliente = await _repository.GetByIdAsync(id);
        var clienteDto = _mapper.Map<ClienteDto>(cliente);
        return clienteDto;
    }

    public async Task CreateAsync(ClienteDto clienteDto)
    {
        var cliente = _mapper.Map<Cliente>(clienteDto);
        await _repository.CreateAsync(cliente);
    }

    public async Task UpdateAsync(ClienteDto clienteDto)
    {
        var cliente = _mapper.Map<Cliente>(clienteDto);
        await _repository.UpdateAsync(cliente);
    }

    public async Task RemoveAsync(ClienteDto clienteDto)
    {
        var cliente = _mapper.Map<Cliente>(clienteDto);
        await _repository.RemoveAsync(cliente);
    }
}