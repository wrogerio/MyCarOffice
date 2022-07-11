using AutoMapper;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _repository;
        private readonly IMapper _mapper;

        public VeiculoService(IVeiculoRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<VeiculoDto>> GetAllAsync()
        {
            var veiculos = await _repository.GetAllAsync();
            var veiculosDto = _mapper.Map<IEnumerable<VeiculoDto>>(veiculos);
            return veiculosDto;
        }

        public async Task<VeiculoDto> GetByIdAsync(Guid id)
        {
            var veiculo = await _repository.GetByIdAsync(id);
            var veiculoDto = _mapper.Map<VeiculoDto>(veiculo);
            return veiculoDto;
        }

        public async Task CreateAsync(VeiculoDto veiculoDto)
        {
            var veiculo = _mapper.Map<Veiculo>(veiculoDto);
            await _repository.CreateAsync(veiculo);
        }

        public async Task UpdateAsync(VeiculoDto veiculoDto)
        {
            var veiculo = _mapper.Map<Veiculo>(veiculoDto);
            await _repository.UpdateAsync(veiculo);
        }

        public async Task RemoveAsync(VeiculoDto veiculoDto)
        {
            var veiculo = _mapper.Map<Veiculo>(veiculoDto);
            await _repository.RemoveAsync(veiculo);
        }
    }
}
