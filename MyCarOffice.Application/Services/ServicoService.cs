using AutoMapper;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services
{
    public class ServicoService : IServicoService
    {
        private readonly IServicoRepository _repository;
        private readonly IMapper _mapper;

        public ServicoService(IServicoRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<ServicoDto>> GetAllAsync()
        {
            var servicos = await _repository.GetAllAsync();
            var sevicosDto = _mapper.Map<IEnumerable<ServicoDto>>(servicos);
            return sevicosDto;
        }

        public async Task<ServicoDto> GetByIdAsync(Guid id)
        {
            var servico = await _repository.GetByIdAsync(id);
            var servicoDto = _mapper.Map<ServicoDto>(servico);
            return servicoDto;
        }

        public async Task CreateAsync(ServicoDto servicoDto)
        {
            var servico = _mapper.Map<Servico>(servicoDto);
            await _repository.CreateAsync(servico);
        }

        public async Task UpdateAsync(ServicoDto servicoDto)
        {
            var servico = _mapper.Map<Servico>(servicoDto);
            await _repository.UpdateAsync(servico);
        }

        public async Task RemoveAsync(ServicoDto servicoDto)
        {
            var servico = _mapper.Map<Servico>(servicoDto);
            await _repository.RemoveAsync(servico);
        }
    }
}
