using System.ComponentModel.DataAnnotations;

namespace MyCarOffice.Application.DTOs.Especializacao;

public class EspecializacaoDtoUpdate: EspecializacaoDtoCreate
{
    [Key] public Guid Id { get; set; }
}