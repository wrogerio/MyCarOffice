using AutoMapper;
using MyCarOffice.Application.DTOs.Commands.Create;
using MyCarOffice.Application.DTOs.Commands.Update;
using MyCarOffice.Application.DTOs.Queries;
using MyCarOffice.Application.DTOs.Queries.CleanDtos;
using MyCarOffice.Domain.Entities;

namespace MyCarOffice.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        #region Cliente

        CreateMap<Cliente, ClienteDto>().ReverseMap()
            .ConstructUsing(dto => new Cliente(dto.Nome, dto.Cpf, dto.DataNasc, dto.Sexo, dto.Logradouro, dto.Telefone));
        
        CreateMap<Cliente, ClienteDtoClean>().ReverseMap()
            .ConstructUsing(dto => new Cliente(dto.Nome, dto.Cpf, dto.DataNasc, dto.Sexo, dto.Logradouro, dto.Telefone));
        
        CreateMap<Cliente, ClienteDtoCreate>().ReverseMap()
            .ConstructUsing(dto => new Cliente(dto.Nome, dto.Cpf, dto.DataNasc, dto.Sexo, dto.Logradouro, dto.Telefone));
        
        CreateMap<Cliente, ClienteDtoUpdate>().ReverseMap()
            .ConstructUsing(dto => new Cliente(dto.Nome, dto.Cpf, dto.DataNasc, dto.Sexo, dto.Logradouro, dto.Telefone));

        #endregion


        CreateMap<Oficina, OficinaDto>().ReverseMap()
            .ConstructUsing(dto => new Oficina(dto.NomeFantasia, dto.Cnpj, dto.NomeResponsavel, dto.Telefone, dto.Logradouro));

        CreateMap<Especializacao, EspecializacaoDto>().ReverseMap()
            .ConstructUsing(dto => new Especializacao(dto.Nome, dto.Since));

        #region Veiculo

        CreateMap<Veiculo, VeiculoDto>().ReverseMap()
            .ConstructUsing(dto => new Veiculo(dto.Marca, dto.Modelo, dto.Placa, dto.Ano));

        CreateMap<Veiculo, VeiculoDtoClean>().ReverseMap()
            .ConstructUsing(dto => new Veiculo(dto.Marca, dto.Modelo, dto.Placa, dto.Ano));

        #endregion


        CreateMap<Veiculo, VeiculoDtoCreateUpdate>().ReverseMap()
            .ConstructUsing(dto => new Veiculo(dto.Marca, dto.Modelo, dto.Placa, dto.Ano));

        CreateMap<VeiculoDto, VeiculoDtoCreateUpdate>().ReverseMap();

        CreateMap<Profissional, ProfissionalDto>().ReverseMap()
            .ConstructUsing(dto => new Profissional(dto.Nome, dto.Cpf, dto.DataNasc, dto.Area));

        CreateMap<Servico, ServicoDto>().ReverseMap()
            .ConstructUsing(dto => new Servico(dto.Area, dto.Nome, dto.Valor, dto.TempoMedio));

        CreateMap<OrdemDeServico, OrdemDeServicoDto>().ReverseMap()
            .ConstructUsing(dto => new OrdemDeServico(
                dto.OficinaNomeFantasia, dto.OficinaCnpj, dto.OficinaNomeResponsavel, dto.OficinaTelefone, dto.OficinaLogradouro,
                dto.ProfissionalNome, dto.ProfissionalCpf, dto.ProfissionalDataNasc, dto.ProfissionalArea, dto.ClienteNome,
                dto.ClienteCpf, dto.ClienteDataNasc, dto.ClienteTelefone, dto.ClienteSexo, dto.ClienteLogradouro,
                dto.VeiculoMarca, dto.VeiculoModelo, dto.VeiculoPlaca, dto.VeiculoAno, dto.ServicoArea, dto.ServicoNome,
                dto.ServicoValor, dto.ServicoTempoMedio));
    }
}