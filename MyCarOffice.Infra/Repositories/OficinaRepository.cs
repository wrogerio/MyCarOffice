using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Context;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Infra.Repositories;

public class OficinaRepository : RepositoryBase<Oficina>, IOficinaRepository
{
    public OficinaRepository(MyCarOfficeContext context) : base(context)
    {
    }
}