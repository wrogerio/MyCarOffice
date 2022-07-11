using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services
{
    public class ServicoService : ServiceBase<Servico>, IServicoService
    {
        public ServicoService(IServicoRepository repository) : base(repository)
        {
        }
    }
}
