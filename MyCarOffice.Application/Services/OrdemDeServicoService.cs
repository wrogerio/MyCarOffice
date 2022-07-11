using AutoMapper;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services
{
    public class OrdemDeServicoService : IOrdemDeServicoService
    {
        private readonly IOrdemDeServicoRepository _repository;
        private readonly IMapper _mapper;

        public OrdemDeServicoService(IOrdemDeServicoRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<OrdemDeServicoDto>> GetAllAsync()
        {
            var ordensDeServicos = await _repository.GetAllAsync();
            var ordensDeServicosDto = _mapper.Map<IEnumerable<OrdemDeServicoDto>>(ordensDeServicos);
            return ordensDeServicosDto;
        }

        public async Task<OrdemDeServicoDto> GetByIdAsync(Guid id)
        {
            var ordemDeServico = await _repository.GetByIdAsync(id);
            var ordemDeServicoDto = _mapper.Map<OrdemDeServicoDto>(ordemDeServico);
            return ordemDeServicoDto;
        }

        public async Task CreateAsync(OrdemDeServicoDto ordemDeServicoDto)
        {
            var ordemDeServico = _mapper.Map<OrdemDeServico>(ordemDeServicoDto);
            await _repository.CreateAsync(ordemDeServico);
        }

        public async Task UpdateAsync(OrdemDeServicoDto ordemDeServicoDto)
        {
            var ordemDeServico = _mapper.Map<OrdemDeServico>(ordemDeServicoDto);
            await _repository.UpdateAsync(ordemDeServico);
        }

        public async Task RemoveAsync(OrdemDeServicoDto ordemDeServicoDto)
        {
            var ordemDeServico = _mapper.Map<OrdemDeServico>(ordemDeServicoDto);
            await _repository.RemoveAsync(ordemDeServico);
        }
    }
}
