using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services
{
    public class ProfissionalService : ServiceBase<Profissional>, IProfissionalService
    {
        public ProfissionalService(IProfissionalRepository repository) : base(repository)
        {
        }
    }
}
