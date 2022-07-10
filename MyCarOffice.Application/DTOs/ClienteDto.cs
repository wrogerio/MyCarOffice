using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.DTOs;

public class ClienteDto
{
    [Key]
    public Guid Id { get; set; }
    
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
    
    public string Logradouro { get; } = "";
    public string Numero { get; } = "";
    public string Complemento { get; set; } = "";
    public string Bairro { get; set; } = "";
    public string Cep { get; set; } = "";
    public string Telefone { get; } = "";
    public virtual IEnumerable<Veiculo>? Veiculos { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
}