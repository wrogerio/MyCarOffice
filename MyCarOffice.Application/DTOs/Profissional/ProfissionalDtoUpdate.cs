using System.ComponentModel.DataAnnotations;

namespace MyCarOffice.Application.DTOs.Profissional;

public class ProfissionalDtoUpdate : ProfissionalDtoCreate
{
    [Key] public Guid Id { get; set; }
}