using System.ComponentModel.DataAnnotations;

namespace MyCarOffice.Application.DTOs.Oficina;

public class OficinaDtoUpdate: OficinaDtoCreate
{
    [Key] public Guid Id { get; set; }
}