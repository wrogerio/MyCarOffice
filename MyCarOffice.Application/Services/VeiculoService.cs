using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services
{
    public class VeiculoService : ServiceBase<Veiculo>, Interfaces.IVeiculoService
    {
        public VeiculoService(IVeiculoRepository repository) : base(repository)
        {
        }
    }
}
