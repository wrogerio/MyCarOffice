using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services;

public class OficinaRepository : ServiceBase<Oficina>, IOficinaService
{
    public OficinaRepository(IOficinaRepository repository) : base(repository)
    {
    }
}