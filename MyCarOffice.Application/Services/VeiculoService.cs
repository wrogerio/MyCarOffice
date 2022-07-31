using AutoMapper;
using MyCarOffice.Application.DTOs.Veiculos;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services;

public class VeiculoService : IVeiculoService
{
    private readonly IMapper _mapper;
    private readonly IVeiculoRepository _repository;

    public VeiculoService(IVeiculoRepository repository, IMapper mapper)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<List<VeiculoDto>> GetAllAsync()
    {
        var veiculos = await _repository.GetAllAsync();
        return EntidadeToDtoList(veiculos.ToList());
    }

    public async Task<VeiculoDto> GetByIdAsync(Guid id)
    {
        var veiculo = await _repository.GetByIdAsync(id);
        return EntidadeToDto(veiculo);
    }

    public async Task CreateAsync(VeiculoDtoCreate veiculoDto)
    {
        var veiculo = _mapper.Map<Veiculo>(veiculoDto);
        await _repository.CreateAsync(veiculo);
    }

    public async Task UpdateAsync(VeiculoDtoUpdate veiculoDto)
    {
        var veiculo = _mapper.Map<Veiculo>(veiculoDto);
        await _repository.UpdateAsync(veiculo);
    }

    public async Task RemoveAsync(VeiculoDto veiculoDto)
    {
        var veiculo = _mapper.Map<Veiculo>(veiculoDto);
        await _repository.RemoveAsync(veiculo);
    }

    private VeiculoDto EntidadeToDto(Veiculo? entidade)
    {
        var objDto = _mapper.Map<VeiculoDto>(entidade);
        return objDto;
    }

    private List<VeiculoDto> EntidadeToDtoList(List<Veiculo> entidades)
    {
        var objDtoList = _mapper.Map<List<VeiculoDto>>(entidades);
        return objDtoList;
    }
}