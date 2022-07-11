namespace MyCarOffice.Infra.Interfaces;

public interface IRepositoryBase<Entity> where Entity : class
{
    Task<IEnumerable<Entity>> GetAllAsync();
    Task<Entity> GetByIdAsync(Guid id);
    Task CreateAsync(Entity entity);
    Task UpdateAsync(Entity entity);
    Task RemoveAsync(Entity entity);
}