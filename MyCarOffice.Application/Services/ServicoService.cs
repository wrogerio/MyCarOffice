using AutoMapper;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services;

public class ServicoService : IServicoService
{
    private readonly IMapper _mapper;
    private readonly IServicoRepository _repository;

    public ServicoService(IServicoRepository repository, IMapper mapper)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<IEnumerable<ServicoDto>> GetAllAsync()
    {
        var servicos = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<ServicoDto>>(servicos);
    }

    public async Task<ServicoDto> GetByIdAsync(Guid id)
    {
        var servico = await _repository.GetByIdAsync(id);
        return _mapper.Map<ServicoDto>(servico);
    }

    public async Task<ServicoDto> CreateAsync(ServicoDto servicoDto)
    {
        var servico = _mapper.Map<Servico>(servicoDto);
        await _repository.CreateAsync(servico);
        return _mapper.Map<ServicoDto>(servico);
    }

    public async Task<ServicoDto> UpdateAsync(ServicoDto servicoDto)
    {
        var servico = _mapper.Map<Servico>(servicoDto);
        await _repository.UpdateAsync(servico);
        return _mapper.Map<ServicoDto>(servico);
    }

    public async Task RemoveAsync(ServicoDto servicoDto)
    {
        var servico = _mapper.Map<Servico>(servicoDto);
        await _repository.RemoveAsync(servico);
    }
}