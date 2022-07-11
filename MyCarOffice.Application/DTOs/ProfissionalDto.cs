using System.ComponentModel.DataAnnotations;
using MyCarOffice.Domain.Enums;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.DTOs;

public class ProfissionalDto
{
    [Key] public Guid Id { get; set; }

    [Required(ErrorMessage = Constants.ProfissionalNomeErrorRequired)]
    [MaxLength(Constants.ProfissionalNomeMaxLength, ErrorMessage = Constants.ProfissionalNomeErrorMaxLength)]
    [Display(Description = Constants.ProfissionalNomeDisplay)]
    public string Nome { get; set; } = "";
    
    [Required(ErrorMessage = Constants.ProfissionalCpfErrorRequired)]
    [MaxLength(Constants.ProfissionalCpfMaxLength, ErrorMessage = Constants.ProfissionalCpfErrorMaxLength)]
    [Display(Description = Constants.ProfissionalCpfDisplay)]
    public string Cpf { get; set; } = "";
    
    [Required(ErrorMessage = Constants.ProfissionalDataNascErrorRequired)]
    [Display(Description = Constants.ProfissionalDataNascDisplay)]
    public DateTime DataNasc { get; set; } = DateTime.Now;
    
    [Required(ErrorMessage = Constants.ProfissionalAreaErrorRequired)]
    [Display(Description = Constants.ProfissionalAreaDisplay)]
    public AreaEnum Area { get; set; } = AreaEnum.Mecanica;
}