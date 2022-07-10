using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Context;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Infra.Repositories
{
    public class EspecializacaoRepository : RepositoryBase<Especializacao>, IEspecializacaoRepository
    {
        public EspecializacaoRepository(MyCarOfficeContext context) : base(context)
        {
        }
    }
}
