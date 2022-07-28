using AutoMapper;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services;

public class ClienteService : IClienteService
{
    private readonly IMapper _mapper;
    private readonly IClienteRepository _repository;

    public ClienteService(IClienteRepository repository, IMapper mapper)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<IEnumerable<ClienteDto>> GetAllAsync()
    {
        var clientes = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<ClienteDto>>(clientes);
    }

    public async Task<ClienteDto> GetByIdAsync(Guid id)
    {
        var cliente = await _repository.GetByIdAsync(id);
        return _mapper.Map<ClienteDto>(cliente);
    }

    public async Task<ClienteDto> CreateAsync(ClienteDto clienteDto)
    {
        var cliente = _mapper.Map<Cliente>(clienteDto);
        await _repository.CreateAsync(cliente);
        return _mapper.Map<ClienteDto>(cliente);
    }

    public async Task<ClienteDto> UpdateAsync(ClienteDto clienteDto)
    {
        var cliente = _mapper.Map<Cliente>(clienteDto);
        await _repository.UpdateAsync(cliente);
        return _mapper.Map<ClienteDto>(cliente);
    }

    public async Task RemoveAsync(ClienteDto clienteDto)
    {
        var cliente = _mapper.Map<Cliente>(clienteDto);
        await _repository.RemoveAsync(cliente);
    }
}