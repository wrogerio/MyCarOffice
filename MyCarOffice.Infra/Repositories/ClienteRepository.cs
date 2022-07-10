using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Context;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Infra.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(MyCarOfficeContext context) : base(context)
        {
        }
    }
}
