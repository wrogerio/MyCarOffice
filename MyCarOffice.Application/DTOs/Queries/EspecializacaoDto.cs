using System.ComponentModel.DataAnnotations;
using MyCarOffice.Domain.Enums;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.DTOs.Queries;

public class EspecializacaoDto
{
    [Key] public Guid Id { get; set; }

    [Required(ErrorMessage = Constants.EspecializacaoNomeErrorRequired)]
    [MaxLength(Constants.EspecializacaoNomeMaxLength, ErrorMessage = Constants.EspecializacaoNomeErrorMaxLength)]
    [Display(Description = Constants.EspecializacaoNomeDisplay)]
    public string Nome { get; set; } = "";

    [Required(ErrorMessage = Constants.EspecializacaoSinceErrorRequired)]
    [Display(Description = Constants.EspecializacaoSinceDisplay)]
    public DateTime Since { get; set; } = DateTime.Now;

    public Guid ProfissionalId { get; set; }

    // Profissional Fields

    [Display(Description = Constants.ProfissionalNomeDisplay)]
    public string ProfissionalNome { get; set; } = "";

    [Display(Description = Constants.ProfissionalCpfDisplay)]
    public string ProfissionalCpf { get; set; } = "";

    [Display(Description = Constants.ProfissionalDataNascDisplay)]
    public DateTime ProfissionalDataNasc { get; set; } = DateTime.Now;

    [Display(Description = Constants.ProfissionalAreaDisplay)]
    public AreaEnum ProfissionalArea { get; set; } = AreaEnum.Mecanica;
}