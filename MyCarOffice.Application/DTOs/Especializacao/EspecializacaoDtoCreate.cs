using System.ComponentModel.DataAnnotations;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.DTOs.Especializacao;

public class EspecializacaoDtoCreate
{
    [Required(ErrorMessage = Constants.EspecializacaoNomeErrorRequired)]
    [MaxLength(Constants.EspecializacaoNomeMaxLength, ErrorMessage = Constants.EspecializacaoNomeErrorMaxLength)]
    [Display(Description = Constants.EspecializacaoNomeDisplay)]
    public string Nome { get; set; } = "";

    [Required(ErrorMessage = Constants.EspecializacaoSinceErrorRequired)]
    [Display(Description = Constants.EspecializacaoSinceDisplay)]
    public DateTime Since { get; set; } = DateTime.Now;

    public Guid ProfissionalId { get; set; }
}