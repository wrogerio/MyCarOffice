namespace MyCarOffice.Application.DTOs.Queries.CleanDtos;

public class ClienteDtoClean
{
    public Guid Id { get; set; }
    public string Nome { get; set; } = "";
    public string Cpf { get; set; } = "";
    public DateTime DataNasc { get; set; } = DateTime.Now;
    public string Email { get; set; } = "";
    public string Sexo { get; set; } = "";
    public string Logradouro { get; set; } = "";
    public string Numero { get; set; } = "";
    public string Complemento { get; set; } = "";
    public string Bairro { get; set; } = "";
    public string Cep { get; set; } = "";
    public string Telefone { get; set; } = "";
}