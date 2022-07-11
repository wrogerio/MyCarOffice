using AutoMapper;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services
{
    public class OficinaService : IOficinaService
    {
        private readonly IOficinaRepository _repository;
        private readonly IMapper _mapper;

        public OficinaService(IOficinaRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<OficinaDto>> GetAllAsync()
        {
            var oficinas = await _repository.GetAllAsync();
            var oficinasDto = _mapper.Map<IEnumerable<OficinaDto>>(oficinas);
            return oficinasDto;
        }

        public async Task<OficinaDto> GetByIdAsync(Guid id)
        {
            var oficina = await _repository.GetByIdAsync(id);
            var oficinaDto = _mapper.Map<OficinaDto>(oficina);
            return oficinaDto;
        }
        public async Task CreateAsync(OficinaDto oficinaDto)
        {
            var oficina = _mapper.Map<Oficina>(oficinaDto);
            await _repository.CreateAsync(oficina);
        }

        public async Task UpdateAsync(OficinaDto oficinaDto)
        {
            var oficina = _mapper.Map<Oficina>(oficinaDto);
            await _repository.UpdateAsync(oficina);
        }

        public async Task RemoveAsync(OficinaDto oficinaDto)
        {
            var oficina = _mapper.Map<Oficina>(oficinaDto);
            await _repository.RemoveAsync(oficina);
        }
    }
}
