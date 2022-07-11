namespace MyCarOffice.Application.Interfaces;

public interface IServiceBase<Entity> where Entity : class
{
    Task<IEnumerable<Entity>> GetAllAsync();
    Task<Entity> GetByIdAsync(Guid id);
    Task CreateAsync(Entity entity);
    Task UpdateAsync(Entity entity);
    Task DeleteAsync(Entity entity);
}