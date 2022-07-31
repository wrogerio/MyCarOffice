using System.ComponentModel.DataAnnotations;

namespace MyCarOffice.Application.DTOs.Veiculos;

public class VeiculoDtoUpdate : VeiculoDtoCreate
{
    [Key] public Guid Id { get; set; }
}