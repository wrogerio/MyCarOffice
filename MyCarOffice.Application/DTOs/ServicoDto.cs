using System.ComponentModel.DataAnnotations;
using MyCarOffice.Domain.Enums;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.DTOs;

public class ServicoDto
{
    [Key] public Guid Id { get; set; }

    [Required(ErrorMessage = Constants.ServicoNomeErrorRequired)]
    [MaxLength(Constants.ServicoNomeMaxLength, ErrorMessage = Constants.ServicoNomeErrorMaxLength)]
    [Display(Description = Constants.ServicoNomeDisplay)]
    public string Nome { get; set; } = "";

    [Required(ErrorMessage = Constants.ServicoAreaErrorRequired)]
    [Display(Description = Constants.ServicoAreaDisplay)]
    public AreaEnum Area { get; set; } = AreaEnum.Mecanica;

    [Required(ErrorMessage = Constants.ServicoValorErrorRequired)]
    [Display(Description = Constants.ServicoValorDisplay)]
    public double Valor { get; set; }

    [Required(ErrorMessage = Constants.ServicoTempoMedioErrorRequired)]
    [Display(Description = Constants.ServicoTempoMedioDisplay)]
    public double TempoMedio { get; set; } = 0d;
}