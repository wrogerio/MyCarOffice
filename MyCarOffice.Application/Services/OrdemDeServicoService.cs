using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services
{
    public class OrdemDeServicoService : ServiceBase<OrdemDeServico>, IOrdemDeServicoService
    {
        public OrdemDeServicoService(IOrdemDeServicoRepository repository) : base(repository)
        {
        }
    }
}
