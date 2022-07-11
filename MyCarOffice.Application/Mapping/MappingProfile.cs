using AutoMapper;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Domain.Entities;

namespace MyCarOffice.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ClienteDto, Cliente>().ReverseMap();
        CreateMap<EspecializacaoDto, Especializacao>().ReverseMap();
        CreateMap<OficinaDto, Oficina>().ReverseMap();
        CreateMap<OrdemDeServicoDto, OrdemDeServico>().ReverseMap();
        CreateMap<ProfissionalDto, Profissional>().ReverseMap();
        CreateMap<ServicoDto, Servico>().ReverseMap();
        CreateMap<VeiculoDto, Veiculo>().ReverseMap();
    }
}