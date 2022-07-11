namespace MyCarOffice.Uow;

public interface IUow
{
    public Task Commit();
    public Task RollBack();
}