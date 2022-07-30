using MyCarOffice.Application.DTOs.Queries.CleanDtos;

namespace MyCarOffice.Application.DTOs.Queries;

public class VeiculoDto : VeiculoDtoClean
{
    public string ClienteNome { get; set; } = "";
    public string ClienteCpf { get; set; } = "";
    public DateTime ClienteDataNasc { get; set; } = DateTime.Now;
    public string ClienteEmail { get; set; } = "";
    public string ClienteSexo { get; set; } = "";
    public string ClienteLogradouro { get; set; } = "";
    public string ClienteNumero { get; set; } = "";
    public string ClienteComplemento { get; set; } = "";
    public string ClienteBairro { get; set; } = "";
    public string ClienteCep { get; set; } = "";
    public string ClienteTelefone { get; set; } = "";
}