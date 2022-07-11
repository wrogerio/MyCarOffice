using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Infra.Interfaces;

namespace MyCarOffice.Application.Services;

public class EspecializacaoService : ServiceBase<Especializacao>, IEspecializacaoService
{
    public EspecializacaoService(IEspecializacaoRepository repository) : base(repository)
    {
    }
}