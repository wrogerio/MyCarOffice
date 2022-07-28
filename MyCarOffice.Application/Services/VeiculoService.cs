using AutoMapper;
using MyCarOffice.Application.DTOs;
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

    public async Task<IEnumerable<VeiculoDto>> GetAllAsync()
    {
        var veiculos = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<VeiculoDto>>(veiculos);
    }

    public async Task<VeiculoDto> GetByIdAsync(Guid id)
    {
        var veiculo = await _repository.GetByIdAsync(id);
        return _mapper.Map<VeiculoDto>(veiculo);
    }

    public async Task<VeiculoDto> CreateAsync(VeiculoDto veiculoDto)
    {
        var veiculo = _mapper.Map<Veiculo>(veiculoDto);
        await _repository.CreateAsync(veiculo);
        return _mapper.Map<VeiculoDto>(veiculo);
    }

    public async Task<VeiculoDto> UpdateAsync(VeiculoDto veiculoDto)
    {
        var veiculo = _mapper.Map<Veiculo>(veiculoDto);
        await _repository.UpdateAsync(veiculo);
        return _mapper.Map<VeiculoDto>(veiculo);
    }

    public async Task RemoveAsync(VeiculoDto veiculoDto)
    {
        var veiculo = _mapper.Map<Veiculo>(veiculoDto);
        await _repository.RemoveAsync(veiculo);
    }
}