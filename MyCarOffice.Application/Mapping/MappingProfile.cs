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
        CreateMap<OrdemDeServicoDto, OrdemDeServico>().ReverseMap();
        CreateMap<ProfissionalDto, Profissional>().ReverseMap();
        CreateMap<ServicoDto, Servico>().ReverseMap();
        CreateMap<VeiculoDto, Veiculo>().ReverseMap();

        
        
        CreateMap<Oficina, OficinaDto>().ReverseMap()
            .ConstructUsing(dto => new Oficina(dto.NomeFantasia, dto.Cnpj, dto.NomeResponsavel, dto.Telefone, dto.Logradouro));
    }
}