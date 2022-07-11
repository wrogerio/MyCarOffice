using MyCarOffice.Infra.Context;

namespace MyCarOffice.Uow;

public class Uow : IUow
{
    private readonly MyCarOfficeContext _context;

    public Uow(MyCarOfficeContext context)
    {
        _context = context;
    }

    public async Task Commit()
    {
        await _context.SaveChangesAsync();
    }

    public Task RollBack()
    {
        return Task.CompletedTask;
    }
}