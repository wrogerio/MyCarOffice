using System.ComponentModel.DataAnnotations;
using MyCarOffice.Helpers.Constants;
using MyCarOffice.Helpers.Methods;

namespace MyCarOffice.Application.DTOs;

public class OficinaDto
{
    [Key] public Guid Id { get; set; }

    [Required(ErrorMessage = Constants.OficinaNomeFantasiaErrorRequired)]
    [MaxLength(Constants.OficinaNomeFantasiaMaxLength, ErrorMessage = Constants.OficinaNomeFantasiaErrorMaxLength)]
    [Display(Description = Constants.OficinaNomeFantasiaDisplay)]
    public string NomeFantasia { get; set; } = "";

    [Required(ErrorMessage = Constants.OficinaCnpjErrorRequired)]
    [MaxLength(Constants.OficinaCnpjMaxLength, ErrorMessage = Constants.OficinaCnpjErrorMaxLength)]
    [Display(Description = Constants.OficinaCnpjDisplay)]
    public string Cnpj { get; set; } = "";

    [Required(ErrorMessage = Constants.OficinaNomeResponsavelErrorRequired)]
    [MaxLength(Constants.OficinaNomeResponsavelMaxLength,
        ErrorMessage = Constants.OficinaNomeResponsavelErrorMaxLength)]
    [Display(Description = Constants.OficinaNomeResponsavelDisplay)]
    public string NomeResponsavel { get; set; } = "";

    [Required(ErrorMessage = Constants.OficinaTelefoneErrorRequired)]
    [MaxLength(Constants.OficinaTelefoneMaxLength, ErrorMessage = Constants.OficinaTelefoneErrorMaxLength)]
    [Display(Description = Constants.OficinaTelefoneDisplay)]
    public string Telefone { get; set; } = "";

    [MaxLength(Constants.OficinaEmailMaxLength, ErrorMessage = Constants.OficinaEmailErrorMaxLength)]
    [Display(Description = Constants.OficinaEmailDisplay)]
    public string Email { get; set; } = "";

    [MaxLength(Constants.OficinaSiteMaxLength, ErrorMessage = Constants.OficinaSiteErrorMaxLength)]
    [Display(Description = Constants.OficinaSiteDisplay)]
    public string Site { get; set; } = "";

    [Required(ErrorMessage = Constants.OficinaLogradouroErrorRequired)]
    [MaxLength(Constants.OficinaLogradouroMaxLength, ErrorMessage = Constants.OficinaLogradouroErrorMaxLength)]
    [Display(Description = Constants.OficinaLogradouroDisplay)]
    public string Logradouro { get; set; } = "";

    [MaxLength(Constants.OficinaNumeroMaxLength, ErrorMessage = Constants.OficinaNumeroErrorMaxLength)]
    [Display(Description = Constants.OficinaNumeroDisplay)]
    public string Numero { get; set; } = "";

    [MaxLength(Constants.OficinaComplementoMaxLength, ErrorMessage = Constants.OficinaComplementoErrorMaxLength)]
    [Display(Description = Constants.OficinaComplementoDisplay)]
    public string Complemento { get; set; } = "";

    [MaxLength(Constants.OficinaBairroMaxLength, ErrorMessage = Constants.OficinaBairroErrorMaxLength)]
    [Display(Description = Constants.OficinaBairroDisplay)]
    public string Bairro { get; set; } = "";

    [MaxLength(Constants.OficinaCepMaxLength, ErrorMessage = Constants.OficinaCepErrorMaxLength)]
    [Display(Description = Constants.OficinaCepDisplay)]
    public string Cep { get; set; } = "";

    public bool ValidarEntidade(OficinaDto dto) => MyOfficeMethods.ValidRequireds<OficinaDto>(dto);
}