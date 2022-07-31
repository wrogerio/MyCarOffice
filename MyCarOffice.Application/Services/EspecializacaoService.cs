using AutoMapper;
using MyCarOffice.Application.DTOs.Especializacao;
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

    public async Task<List<EspecializacaoDto>> GetAllAsync()
    {
        var especializacoes = await _repository.GetAllAsync();
        return EntidadeToDtoList(especializacoes.ToList());
    }

    public async Task<EspecializacaoDto> GetByIdAsync(Guid id)
    {
        var especializacao = await _repository.GetByIdAsync(id);
        return EntidadeToDto(especializacao);
    }

    public async Task CreateAsync(EspecializacaoDtoCreate especializacaoDto)
    {
        var especializacao = _mapper.Map<Especializacao>(especializacaoDto);
        await _repository.CreateAsync(especializacao);
    }

    public async Task UpdateAsync(EspecializacaoDtoUpdate especializacaoDto)
    {
        var especializacao = _mapper.Map<Especializacao>(especializacaoDto);
        await _repository.UpdateAsync(especializacao);
    }

    public async Task RemoveAsync(EspecializacaoDto especializacaoDto)
    {
        var especializacao = _mapper.Map<Especializacao>(especializacaoDto);
        await _repository.RemoveAsync(especializacao);
    }

    private EspecializacaoDto EntidadeToDto(Especializacao? entidade)
    {
        var objDto = _mapper.Map<EspecializacaoDto>(entidade);
        return objDto;
    }

    private List<EspecializacaoDto> EntidadeToDtoList(List<Especializacao> entidades)
    {
        var objDtoList = _mapper.Map<List<EspecializacaoDto>>(entidades);
        return objDtoList;
    }
}