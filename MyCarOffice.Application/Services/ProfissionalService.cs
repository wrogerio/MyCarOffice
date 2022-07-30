using AutoMapper;
using MyCarOffice.Application.DTOs.Queries;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services;

public class ProfissionalService : IProfissionalService
{
    private readonly IMapper _mapper;
    private readonly IProfissionalRepository _repository;

    public ProfissionalService(IProfissionalRepository repository, IMapper mapper)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<IEnumerable<ProfissionalDto>> GetAllAsync()
    {
        var profissionais = await _repository.GetAllAsync();
        return EntidadeToDtoList(profissionais.ToList());
    }

    public async Task<ProfissionalDto> GetByIdAsync(Guid id)
    {
        var profissional = await _repository.GetByIdAsync(id);
        return EntidadeToDto(profissional);
    }

    public async Task CreateAsync(ProfissionalDto profissionalDto)
    {
        var profissional = _mapper.Map<Profissional>(profissionalDto);
        await _repository.CreateAsync(profissional);
    }

    public async Task UpdateAsync(ProfissionalDto profissionalDto)
    {
        var profissional = _mapper.Map<Profissional>(profissionalDto);
        await _repository.UpdateAsync(profissional);
    }

    public async Task RemoveAsync(ProfissionalDto profissionalDto)
    {
        var profissional = _mapper.Map<Profissional>(profissionalDto);
        await _repository.RemoveAsync(profissional);
    }

    private ProfissionalDto EntidadeToDto(Profissional? entidade)
    {
        var objDto = _mapper.Map<ProfissionalDto>(entidade);
        return objDto;
    }

    private List<ProfissionalDto> EntidadeToDtoList(List<Profissional> entidades)
    {
        var objDtoList = _mapper.Map<List<ProfissionalDto>>(entidades);
        return objDtoList;
    }
}