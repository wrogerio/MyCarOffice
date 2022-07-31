using System.ComponentModel.DataAnnotations;
using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Application.DTOs.OrdemDeServico;

public class OrdemDeServicoDtoClean
{
    [Key] public Guid Id { get; set; }
    public DateTime DataHoraInicio { get; set; } = DateTime.Now;
    public string ClienteNome { get; set; } = "";
    public DateTime ClienteDataNasc { get; set; }
    public string ClienteCpf { get; set; } = "";
    public string ClienteSexo { get; set; } = "";
    public string ClienteEmail { get; set; } = "";
    public string ClienteLogradouro { get; set; } = "";
    public string ClienteNumero { get; set; } = "";
    public string ClienteComplemento { get; set; } = "";
    public string ClienteBairro { get; set; } = "";
    public string ClienteCep { get; set; } = "";
    public string ClienteTelefone { get; set; } = "";
    public string VeiculoMarca { get; set; } = "";
    public string VeiculoModelo { get; set; } = "";
    public string VeiculoPlaca { get; set; } = "";
    public int VeiculoAno { get; set; }
    public string VeiculoCor { get; set; } = "";
    public string VeiculoObservacao { get; set; } = "";
    public AreaEnum ServicoArea { get; set; } = AreaEnum.Mecanica;
    public string ServicoNome { get; set; } = "";
    public double ServicoValor { get; set; }
    public double ServicoTempoMedio { get; set; }
    public string ProfissionalNome { get; set; } = "";
    public string ProfissionalCpf { get; set; } = "";
    public DateTime ProfissionalDataNasc { get; set; }
    public int ProfissionalArea { get; set; }
    public string OficinaNomeFantasia { get; set; } = "";
    public string OficinaCnpj { get; set; } = "";
    public string OficinaTelefone { get; set; } = "";
    public string OficinaEmail { get; set; } = "";
    public string OficinaNomeResponsavel { get; set; } = "";
    public string OficinaSite { get; set; } = "";
    public string OficinaLogradouro { get; set; } = "";
    public string OficinaNumero { get; set; } = "";
    public string OficinaComplemento { get; set; } = "";
    public string OficinaBairro { get; set; } = "";
    public string OficinaCep { get; set; } = "";
    public DateTime? DataHoraEncerramento { get; set; }
    public DateTime? TempoTotal { get; set; }
}