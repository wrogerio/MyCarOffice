using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services;

public class VeiculoService : ServiceBase<Veiculo>, IVeiculoService
{
    public VeiculoService(IVeiculoRepository repository) : base(repository)
    {
    }
}