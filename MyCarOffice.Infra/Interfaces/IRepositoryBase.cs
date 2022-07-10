namespace MyCarOffice.Infra.Interfaces
{
    public interface IRepositoryBase<Entity> where Entity : class
    {
        Task<IEnumerable<Entity>> GetAllAsync();
        Task<Entity> GetByIdAsync(Guid id);
        void Create(Entity entity);
        void Update(Entity entity);
        void Delete(Entity entity);
    }
}
