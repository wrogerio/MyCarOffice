using AutoMapper;
using MyCarOffice.Application.DTOs;
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
        return _mapper.Map<IEnumerable<ProfissionalDto>>(profissionais);
    }

    public async Task<ProfissionalDto> GetByIdAsync(Guid id)
    {
        var profissional = await _repository.GetByIdAsync(id);
        return _mapper.Map<ProfissionalDto>(profissional);
    }

    public async Task<ProfissionalDto> CreateAsync(ProfissionalDto profissionalDto)
    {
        var profissional = _mapper.Map<Profissional>(profissionalDto);
        await _repository.CreateAsync(profissional);
        return _mapper.Map<ProfissionalDto>(profissional);
    }

    public async Task<ProfissionalDto> UpdateAsync(ProfissionalDto profissionalDto)
    {
        var profissional = _mapper.Map<Profissional>(profissionalDto);
        await _repository.UpdateAsync(profissional);
        return _mapper.Map<ProfissionalDto>(profissional);
    }

    public async Task RemoveAsync(ProfissionalDto profissionalDto)
    {
        var profissional = _mapper.Map<Profissional>(profissionalDto);
        await _repository.RemoveAsync(profissional);
    }
}