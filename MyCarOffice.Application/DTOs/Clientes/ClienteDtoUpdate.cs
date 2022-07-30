using System.ComponentModel.DataAnnotations;
using MyCarOffice.Application.DTOs.Commands.Create;

namespace MyCarOffice.Application.DTOs.Commands.Update;

public class ClienteDtoUpdate : ClienteDtoCreate
{
    [Key] public Guid Id { get; set; }
}