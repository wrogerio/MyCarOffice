using AutoMapper;
using MyCarOffice.Application.DTOs.Servico;
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

    public async Task<List<ServicoDto>> GetAllAsync()
    {
        var servicos = await _repository.GetAllAsync();
        return EntidadeToDtoList(servicos.ToList());
    }

    public async Task<ServicoDto> GetByIdAsync(Guid id)
    {
        var servico = await _repository.GetByIdAsync(id);
        return EntidadeToDto(servico);
    }

    public async Task CreateAsync(ServicoDtoCreate servicoDto)
    {
        var servico = _mapper.Map<Servico>(servicoDto);
        await _repository.CreateAsync(servico);
    }

    public async Task UpdateAsync(ServicoDtoUpdate servicoDto)
    {
        var servico = _mapper.Map<Servico>(servicoDto);
        await _repository.UpdateAsync(servico);
    }

    public async Task RemoveAsync(ServicoDto servicoDto)
    {
        var servico = _mapper.Map<Servico>(servicoDto);
        await _repository.RemoveAsync(servico);
    }

    private ServicoDto EntidadeToDto(Servico? entidade)
    {
        var objDto = _mapper.Map<ServicoDto>(entidade);
        return objDto;
    }

    private List<ServicoDto> EntidadeToDtoList(List<Servico> entidades)
    {
        var objDtoList = _mapper.Map<List<ServicoDto>>(entidades);
        return objDtoList;
    }
}