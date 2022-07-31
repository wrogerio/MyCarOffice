using System.ComponentModel.DataAnnotations;

namespace MyCarOffice.Application.DTOs.Servico;

public class ServicoDtoUpdate: ServicoDtoCreate
{
    [Key] public Guid Id { get; set; }
}