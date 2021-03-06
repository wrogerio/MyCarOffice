using AutoMapper;
using MyCarOffice.Application.DTOs.OrdemDeServico;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services;

public class OrdemDeServicoService : IOrdemDeServicoService
{
    private readonly IMapper _mapper;
    private readonly IOrdemDeServicoRepository _repository;

    public OrdemDeServicoService(IOrdemDeServicoRepository repository, IMapper mapper)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<List<OrdemDeServicoDto>> GetAllAsync()
    {
        var ordensDeServicos = await _repository.GetAllAsync();
        return EntidadeToDtoList(ordensDeServicos.ToList());
    }

    public async Task<OrdemDeServicoDto> GetByIdAsync(Guid id)
    {
        var ordemDeServico = await _repository.GetByIdAsync(id);
        return EntidadeToDto(ordemDeServico);
    }

    public async Task CreateAsync(OrdemDeServicoDtoCreate ordemDeServicoDto)
    {
        var ordemDeServico = _mapper.Map<OrdemDeServico>(ordemDeServicoDto);
        await _repository.CreateAsync(ordemDeServico);
    }

    public async Task UpdateAsync(OrdemDeServicoDtoUpdate ordemDeServicoDto)
    {
        var ordemDeServico = _mapper.Map<OrdemDeServico>(ordemDeServicoDto);
        await _repository.UpdateAsync(ordemDeServico);
    }

    public async Task RemoveAsync(OrdemDeServicoDto ordemDeServicoDto)
    {
        var ordemDeServico = _mapper.Map<OrdemDeServico>(ordemDeServicoDto);
        await _repository.RemoveAsync(ordemDeServico);
    }

    private OrdemDeServicoDto EntidadeToDto(OrdemDeServico? entidade)
    {
        var objDto = _mapper.Map<OrdemDeServicoDto>(entidade);
        return objDto;
    }

    private List<OrdemDeServicoDto> EntidadeToDtoList(List<OrdemDeServico> entidades)
    {
        var objDtoList = _mapper.Map<List<OrdemDeServicoDto>>(entidades);
        return objDtoList;
    }
}