using Microsoft.EntityFrameworkCore;
using MyCarOffice.Infra.Context;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Infra.Repositories;

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

    public async Task CreateAsync(Entity entity)
    {
        await _context.Set<Entity>().AddAsync(entity);
    }

    public async Task UpdateAsync(Entity entity)
    {
        _context.ChangeTracker.Clear();
        _context.Entry(entity).State = EntityState.Modified;
    }

    public async Task RemoveAsync(Entity entity)
    {
        _context.ChangeTracker.Clear();
        _context.Remove(entity);
    }
}