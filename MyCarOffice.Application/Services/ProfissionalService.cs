using AutoMapper;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services
{
    public class ProfissionalService : IProfissionalService
    {
        private readonly IProfissionalRepository _repository;
        private readonly IMapper _mapper;

        public ProfissionalService(IProfissionalRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<ProfissionalDto>> GetAllAsync()
        {
            var profissionais = await _repository.GetAllAsync();
            var profissionaisDto = _mapper.Map<IEnumerable<ProfissionalDto>>(profissionais);
            return profissionaisDto;
        }

        public async Task<ProfissionalDto> GetByIdAsync(Guid id)
        {
            var profissional = await _repository.GetByIdAsync(id);
            var profissionalDto = _mapper.Map<ProfissionalDto>(profissional);
            return profissionalDto;
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
    }
}
