using AutoMapper;
using MyCarOffice.Application.DTOs.Commands.Create;
using MyCarOffice.Application.DTOs.Commands.Update;
using MyCarOffice.Application.DTOs.Queries;
using MyCarOffice.Application.DTOs.Queries.CleanDtos;
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
        return EntidadeToDtoList(clientes.ToList());
    }

    public async Task<ClienteDto> GetByIdAsync(Guid id)
    {
        var cliente = await _repository.GetByIdAsync(id);
        return EntidadeToDto(cliente);
    }

    public async Task<ClienteDtoClean> CreateAsync(ClienteDtoCreate clienteDto)
    {
        var cliente = _mapper.Map<Cliente>(clienteDto);
        await _repository.CreateAsync(cliente);
        return EntidadeToDtoClean(cliente);
    }

    public async Task<ClienteDtoClean> UpdateAsync(ClienteDtoUpdate clienteDto)
    {
        var cliente = _mapper.Map<Cliente>(clienteDto);
        await _repository.UpdateAsync(cliente);
        return EntidadeToDtoClean(cliente);
    }

    public async Task RemoveAsync(ClienteDto clienteDto)
    {
        var cliente = _mapper.Map<Cliente>(clienteDto);
        await _repository.RemoveAsync(cliente);
    }

    private ClienteDto EntidadeToDto(Cliente? entidade)
    {
        var objDto = _mapper.Map<ClienteDto>(entidade);
        return objDto;
    }
    
    private ClienteDtoClean EntidadeToDtoClean(Cliente? entidade)
    {
        var objDto = _mapper.Map<ClienteDtoClean>(entidade);
        return objDto;
    }

    private List<ClienteDto> EntidadeToDtoList(List<Cliente> entidades)
    {
        var objDtoList = _mapper.Map<List<ClienteDto>>(entidades);
        return objDtoList;
    }
    
    private List<ClienteDtoClean> EntidadeToDtoCleanList(List<Cliente> entidades)
    {
        var objDtoList = _mapper.Map<List<ClienteDtoClean>>(entidades);
        return objDtoList;
    }
}