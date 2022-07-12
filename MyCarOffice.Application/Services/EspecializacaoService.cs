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
        var especializacoesDto = _mapper.Map<IEnumerable<EspecializacaoDto>>(especializacoes);
        return especializacoesDto;
    }

    public async Task<EspecializacaoDto> GetByIdAsync(Guid id)
    {
        var especializacao = await _repository.GetByIdAsync(id);
        var especializacaoDto = _mapper.Map<EspecializacaoDto>(especializacao);
        return especializacaoDto;
    }

    public async Task CreateAsync(EspecializacaoDto especializacaoDto)
    {
        var especializacao = _mapper.Map<Especializacao>(especializacaoDto);
        await _repository.CreateAsync(especializacao);
    }

    public async Task UpdateAsync(EspecializacaoDto especializacaoDto)
    {
        var especializacao = _mapper.Map<Especializacao>(especializacaoDto);
        await _repository.UpdateAsync(especializacao);
    }

    public async Task RemoveAsync(EspecializacaoDto especializacaoDto)
    {
        var especializacao = _mapper.Map<Especializacao>(especializacaoDto);
        await _repository.RemoveAsync(especializacao);
    }
}