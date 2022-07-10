using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Context;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Infra.Repositories;

public class ServicoRepository : RepositoryBase<Servico>, IServicoRepository
{
    public ServicoRepository(MyCarOfficeContext context) : base(context)
    {
    }
}