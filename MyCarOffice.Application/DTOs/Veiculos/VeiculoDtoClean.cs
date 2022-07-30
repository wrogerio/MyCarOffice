using System.ComponentModel.DataAnnotations;

namespace MyCarOffice.Application.DTOs.Veiculos;

public class VeiculoDtoClean
{
    [Key] public Guid Id { get; set; }
    public string Marca { get; set; } = "";
    public string Modelo { get; set; } = "";
    public string Placa { get; set; } = "";
    public int Ano { get; set; }
    public string Cor { get; set; } = "";
    public string Observacao { get; set; } = "";
    public Guid ClienteId { get; set; }
}