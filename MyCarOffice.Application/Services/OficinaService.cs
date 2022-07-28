using AutoMapper;
using MyCarOffice.Application.DTOs;
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
        return _mapper.Map<IEnumerable<OficinaDto>>(oficinas);
    }

    public async Task<OficinaDto> GetByIdAsync(Guid id)
    {
        var oficina = await _repository.GetByIdAsync(id);
        return _mapper.Map<OficinaDto>(oficina);
    }

    public async Task<OficinaDto> CreateAsync(OficinaDto oficinaDto)
    {
        var oficina = _mapper.Map<Oficina>(oficinaDto);
        await _repository.CreateAsync(oficina);
        return _mapper.Map<OficinaDto>(oficina);
    }

    public async Task<OficinaDto> UpdateAsync(OficinaDto oficinaDto)
    {
        var oficina = _mapper.Map<Oficina>(oficinaDto);
        // var oficina = new Oficina(oficinaDto.NomeFantasia, oficinaDto.Cnpj, oficinaDto.NomeResponsavel, oficinaDto.Telefone, oficinaDto.Logradouro)
        // {
        //     Bairro = oficinaDto.Bairro
        // };
        await _repository.UpdateAsync(oficina);
        return _mapper.Map<OficinaDto>(oficina);
    }

    public async Task RemoveAsync(OficinaDto oficinaDto)
    {
        var oficina = _mapper.Map<Oficina>(oficinaDto);
        await _repository.RemoveAsync(oficina);
    }
}