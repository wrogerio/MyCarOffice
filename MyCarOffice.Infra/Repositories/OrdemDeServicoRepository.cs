using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Context;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Infra.Repositories;

public class OrdemDeServicoRepository : RepositoryBase<OrdemDeServico>, IOrdemDeServicoRepository
{
    public OrdemDeServicoRepository(MyCarOfficeContext context) : base(context)
    {
    }
}