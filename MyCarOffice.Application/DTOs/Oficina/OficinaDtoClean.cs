using System.ComponentModel.DataAnnotations;

namespace MyCarOffice.Application.DTOs.Oficina;

public class OficinaDtoClean
{
    [Key] public Guid Id { get; set; }
    public string NomeFantasia { get; set; } = "";
    public string Cnpj { get; set; } = "";
    public string NomeResponsavel { get; set; } = "";
    public string Telefone { get; set; } = "";
    public string Email { get; set; } = "";
    public string Site { get; set; } = "";
    public string Logradouro { get; set; } = "";
    public string Numero { get; set; } = "";
    public string Complemento { get; set; } = "";
    public string Bairro { get; set; } = "";
    public string Cep { get; set; } = "";
}