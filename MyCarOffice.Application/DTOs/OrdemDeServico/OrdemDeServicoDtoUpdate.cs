using System.ComponentModel.DataAnnotations;

namespace MyCarOffice.Application.DTOs.OrdemDeServico;

public class OrdemDeServicoDtoUpdate: OrdemDeServicoDtoCreate
{
    [Key] public Guid Id { get; set; }
}