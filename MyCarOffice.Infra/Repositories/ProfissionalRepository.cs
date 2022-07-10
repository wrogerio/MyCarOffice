using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Context;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Infra.Repositories;

public class ProfissionalRepository : RepositoryBase<Profissional>, IProfissionalRepository
{
    public ProfissionalRepository(MyCarOfficeContext context) : base(context)
    {
    }
}