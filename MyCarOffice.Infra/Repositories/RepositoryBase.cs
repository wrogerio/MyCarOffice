using Microsoft.EntityFrameworkCore;
using MyCarOffice.Infra.Context;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Infra.Repositories
{
    public class RepositoryBase<Entity> : IRepositoryBase<Entity> where Entity : class
    {
        // Context Injection
        private readonly MyCarOfficeContext _context;

        public RepositoryBase(MyCarOfficeContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return await _context.Set<Entity>().ToListAsync();
        }

        public async Task<Entity> GetByIdAsync(Guid id)
        {
            return await _context.Set<Entity>().FindAsync(id);
        }

        public void Create(Entity entity)
        {
            _context.Set<Entity>().Add(entity);
        }

        public void Update(Entity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(Entity entity)
        {
            _context.Remove(entity);
        }
    }
}
