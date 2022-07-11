using System.ComponentModel.DataAnnotations;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.DTOs;

public class ClienteDto
{
    [Key] public Guid Id { get; set; }

    [Required(ErrorMessage = Constants.ClienteNomeErrorRequired)]
    [MaxLength(Constants.ClienteNomeMaxLength, ErrorMessage = Constants.ClienteNomeErrorMaxLength)]
    [Display(Description = Constants.ClienteNomeDisplay)]
    public string Nome { get; } = "";

    [Required(ErrorMessage = Constants.ClienteCpfErrorRequired)]
    [MaxLength(Constants.ClienteCpfMaxLength, ErrorMessage = Constants.ClienteCpfErrorMaxLength)]
    [Display(Description = Constants.ClienteCpfDisplay)]
    public string Cpf { get; } = "";

    [Required(ErrorMessage = Constants.ClienteDataNascErrorRequired)]
    [Display(Description = Constants.ClienteDataNascDisplay)]
    public DateTime DataNasc { get; } = DateTime.Now;

    [MaxLength(Constants.ClienteEmailMaxLength, ErrorMessage = Constants.ClienteEmailErrorMaxLength)]
    [Display(Description = Constants.ClienteEmailDisplay)]
    public string Email { get; } = "";

    [Required(ErrorMessage = Constants.ClienteSexoErrorRequired)]
    [MaxLength(Constants.ClienteSexoMaxLength, ErrorMessage = Constants.ClienteSexolErrorMaxLength)]
    [Display(Description = Constants.ClienteSexoDisplay)]
    public string Sexo { get; } = "";

    [Required(ErrorMessage = Constants.ClienteLogradouroErrorRequired)]
    [MaxLength(Constants.ClienteLogradouroMaxLength, ErrorMessage = Constants.ClienteLogradouroErrorMaxLength)]
    [Display(Description = Constants.ClienteLogradouroDisplay)]
    public string Logradouro { get; } = "";

    [MaxLength(Constants.ClienteNumeroMaxLength, ErrorMessage = Constants.ClienteNumeroErrorMaxLength)]
    [Display(Description = Constants.ClienteNumeroDisplay)]
    public string Numero { get; } = "";

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
    public string Telefone { get; } = "";

    public virtual IEnumerable<Veiculo>? Veiculos { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
}