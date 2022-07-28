using AutoMapper;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services;

public class EspecializacaoService : IEspecializacaoService
{
    private readonly IMapper _mapper;
    private readonly IEspecializacaoRepository _repository;

    public EspecializacaoService(IEspecializacaoRepository repository, IMapper mapper)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<IEnumerable<EspecializacaoDto>> GetAllAsync()
    {
        var especializacoes = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<EspecializacaoDto>>(especializacoes);
    }

    public async Task<EspecializacaoDto> GetByIdAsync(Guid id)
    {
        var especializacao = await _repository.GetByIdAsync(id);
        return _mapper.Map<EspecializacaoDto>(especializacao);
    }

    public async Task<EspecializacaoDto> CreateAsync(EspecializacaoDto especializacaoDto)
    {
        var especializacao = _mapper.Map<Especializacao>(especializacaoDto);
        await _repository.CreateAsync(especializacao);
        return _mapper.Map<EspecializacaoDto>(especializacao);
    }

    public async Task<EspecializacaoDto> UpdateAsync(EspecializacaoDto especializacaoDto)
    {
        var especializacao = _mapper.Map<Especializacao>(especializacaoDto);
        await _repository.UpdateAsync(especializacao);
        return _mapper.Map<EspecializacaoDto>(especializacao);
    }

    public async Task RemoveAsync(EspecializacaoDto especializacaoDto)
    {
        var especializacao = _mapper.Map<Especializacao>(especializacaoDto);
        await _repository.RemoveAsync(especializacao);
    }
}