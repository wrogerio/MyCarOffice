using AutoMapper;
using MyCarOffice.Application.DTOs.Queries;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services;

public class OficinaService : IOficinaService
{
    private readonly IMapper _mapper;
    private readonly IOficinaRepository _repository;

    public OficinaService(IOficinaRepository repository, IMapper mapper)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<IEnumerable<OficinaDto>> GetAllAsync()
    {
        var oficinas = await _repository.GetAllAsync();
        return EntidadeToDtoList(oficinas.ToList());
    }

    public async Task<OficinaDto> GetByIdAsync(Guid id)
    {
        var oficina = await _repository.GetByIdAsync(id);
        return EntidadeToDto(oficina);
    }

    public async Task CreateAsync(OficinaDto oficinaDto)
    {
        var oficina = _mapper.Map<Oficina>(oficinaDto);
        await _repository.CreateAsync(oficina);
    }

    public async Task UpdateAsync(OficinaDto oficinaDto)
    {
        var oficina = _mapper.Map<Oficina>(oficinaDto);
        await _repository.UpdateAsync(oficina);
    }

    public async Task RemoveAsync(OficinaDto oficinaDto)
    {
        var oficina = _mapper.Map<Oficina>(oficinaDto);
        await _repository.RemoveAsync(oficina);
    }

    private OficinaDto EntidadeToDto(Oficina? entidade)
    {
        var objDto = _mapper.Map<OficinaDto>(entidade);
        return objDto;
    }

    private List<OficinaDto> EntidadeToDtoList(List<Oficina> entidades)
    {
        var objDtoList = _mapper.Map<List<OficinaDto>>(entidades);
        return objDtoList;
    }
}