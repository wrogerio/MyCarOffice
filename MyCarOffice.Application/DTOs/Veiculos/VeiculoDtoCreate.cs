using System.ComponentModel.DataAnnotations;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.DTOs.Veiculos;

public class VeiculoDtoCreate
{
    [Required(ErrorMessage = Constants.VeiculoMarcaErrorRequired)]
    [MaxLength(Constants.VeiculoMarcaMaxLength, ErrorMessage = Constants.VeiculoMarcaErrorMaxLength)]
    [Display(Description = Constants.VeiculoMarcaDisplay)]
    public string Marca { get; set; } = "";

    [Required(ErrorMessage = Constants.VeiculoModeloErrorRequired)]
    [MaxLength(Constants.VeiculoModeloMaxLength, ErrorMessage = Constants.VeiculoModeloErrorMaxLength)]
    [Display(Description = Constants.VeiculoModeloDisplay)]
    public string Modelo { get; set; } = "";

    [Required(ErrorMessage = Constants.VeiculoPlacaErrorRequired)]
    [MaxLength(Constants.VeiculoPlacaMaxLength, ErrorMessage = Constants.VeiculoPlacaErrorMaxLength)]
    [Display(Description = Constants.VeiculoPlacaDisplay)]
    public string Placa { get; set; } = "";

    [Required(ErrorMessage = Constants.VeiculoAnoErrorRequired)]
    [Display(Description = Constants.VeiculoAnoDisplay)]
    public int Ano { get; set; }

    [MaxLength(Constants.VeiculoCorMaxLength, ErrorMessage = Constants.VeiculoCorErrorMaxLength)]
    [Display(Description = Constants.VeiculoCorDisplay)]
    public string Cor { get; set; } = "";

    [MaxLength(Constants.VeiculoObservacaoMaxLength, ErrorMessage = Constants.VeiculoObservacaoErrorMaxLength)]
    [Display(Description = Constants.VeiculoObservacaoDisplay)]
    public string Observacao { get; set; } = "";

    //Relacionamentos
    public Guid ClienteId { get; set; }
}