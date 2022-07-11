using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        public ClienteService(IClienteRepository repository) : base(repository)
        {
        }
    }
}
