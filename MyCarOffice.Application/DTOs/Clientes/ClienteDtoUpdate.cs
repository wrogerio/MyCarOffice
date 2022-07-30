using System.ComponentModel.DataAnnotations;

namespace MyCarOffice.Application.DTOs.Clientes;

public class ClienteDtoUpdate : ClienteDtoCreate
{
    [Key] public Guid Id { get; set; }
}