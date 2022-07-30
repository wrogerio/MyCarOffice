using System.ComponentModel.DataAnnotations;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.DTOs.Commands.Create;

public class ClienteDtoCreate
{
    [Required(ErrorMessage = Constants.ClienteNomeErrorRequired)]
    [MaxLength(Constants.ClienteNomeMaxLength, ErrorMessage = Constants.ClienteNomeErrorMaxLength)]
    [Display(Description = Constants.ClienteNomeDisplay)]
    public string Nome { get; set; } = "";

    [Required(ErrorMessage = Constants.ClienteCpfErrorRequired)]
    [MaxLength(Constants.ClienteCpfMaxLength, ErrorMessage = Constants.ClienteCpfErrorMaxLength)]
    [Display(Description = Constants.ClienteCpfDisplay)]
    public string Cpf { get; set; } = "";

    [Required(ErrorMessage = Constants.ClienteDataNascErrorRequired)]
    [Display(Description = Constants.ClienteDataNascDisplay)]
    public DateTime DataNasc { get; set; } = DateTime.Now;

    [MaxLength(Constants.ClienteEmailMaxLength, ErrorMessage = Constants.ClienteEmailErrorMaxLength)]
    [Display(Description = Constants.ClienteEmailDisplay)]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = Constants.ClienteSexoErrorRequired)]
    [MaxLength(Constants.ClienteSexoMaxLength, ErrorMessage = Constants.ClienteSexoErrorMaxLength)]
    [Display(Description = Constants.ClienteSexoDisplay)]
    public string Sexo { get; set; } = "";

    [Required(ErrorMessage = Constants.ClienteLogradouroErrorRequired)]
    [MaxLength(Constants.ClienteLogradouroMaxLength, ErrorMessage = Constants.ClienteLogradouroErrorMaxLength)]
    [Display(Description = Constants.ClienteLogradouroDisplay)]
    public string Logradouro { get; set; } = "";

    [MaxLength(Constants.ClienteNumeroMaxLength, ErrorMessage = Constants.ClienteNumeroErrorMaxLength)]
    [Display(Description = Constants.ClienteNumeroDisplay)]
    public string Numero { get; set; } = "";

    [MaxLength(Constants.ClienteComplementoMaxLength, ErrorMessage = Constants.ClienteComplementoErrorMaxLength)]
    [Display(Description = Constants.ClienteComplementoDisplay)]
    public string Complemento { get; set; } = "";

    [MaxLength(Constants.ClienteBairroMaxLength, ErrorMessage = Constants.ClienteBairroErrorMaxLength)]
    [Display(Description = Constants.ClienteBairroDisplay)]
    public string Bairro { get; set; } = "";

    [MaxLength(Constants.ClienteCepMaxLength, ErrorMessage = Constants.ClienteCepErrorMaxLength)]
    [Display(Description = Constants.ClienteCepDisplay)]
    public string Cep { get; set; } = "";

    [Required(ErrorMessage = Constants.ClienteTelefoneErrorRequired)]
    [MaxLength(Constants.ClienteTelefoneMaxLength, ErrorMessage = Constants.ClienteTelefoneErrorMaxLength)]
    [Display(Description = Constants.ClienteTelefoneDisplay)]
    public string Telefone { get; set; } = "";
}