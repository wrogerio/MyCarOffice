namespace MyCarOffice.Infra.Interfaces;

public interface IRepositoryBase<Entity> where Entity : class
{
    Task<IEnumerable<Entity>> GetAllAsync();
    Task<Entity?> GetByIdAsync(Guid id);
    Task<Entity> CreateAsync(Entity entity);
    Task<Entity> UpdateAsync(Entity entity);
    Task RemoveAsync(Entity entity);
}