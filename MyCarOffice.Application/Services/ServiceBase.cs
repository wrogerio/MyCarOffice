using MyCarOffice.Application.Interfaces;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services
{
    public class ServiceBase<Entity> : IServiceBase<Entity> where Entity : class
    {
        // Repository Injection
        private readonly IRepositoryBase<Entity> _repository;

        public ServiceBase(IRepositoryBase<Entity> repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(Entity entity)
        {
            await _repository.CreateAsync(entity);
        }

        public async Task DeleteAsync(Entity entity)
        {
            await _repository.DeleteAsync(entity);
        }

        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Entity> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Entity entity)
        {
            await _repository.UpdateAsync(entity);
        }
    }
}
