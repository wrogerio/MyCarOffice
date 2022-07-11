using System.ComponentModel.DataAnnotations;
using MyCarOffice.Domain.Enums;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.DTOs;

public class OrdemDeServicoDto
{
    [Key] public Guid Id { get; set; }
    
    [Required(ErrorMessage = Constants.OrdemDeServicoDataHoraInicioErrorRequired)]
    [Display(Description = Constants.OrdemDeServicoDataHoraInicioDisplay)]
    public DateTime DataHoraInicio { get; set; } = DateTime.Now;
    
    [Required(ErrorMessage = Constants.OrdemDeServicoClienteNomeErrorRequired)]
    [MaxLength(Constants.ClienteNomeMaxLength, ErrorMessage = Constants.ClienteNomeErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoClienteNomeDisplay)]
    public string ClienteNome { get; set; } = "";
    
    [Required(ErrorMessage = Constants.OrdemDeServicoClienteCpfErrorRequired)]
    [MaxLength(Constants.ClienteCpfMaxLength, ErrorMessage = Constants.ClienteCpfErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoClienteCpfDisplay)]
    public string ClienteCpf { get; set; } = "";
    
    [Required(ErrorMessage = Constants.OrdemDeServicoClienteEmailErrorRequired)]
    [MaxLength(Constants.ClienteEmailMaxLength, ErrorMessage = Constants.ClienteEmailErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoClienteEmailDisplay)]
    public string ClienteEmail { get; set; } = "";
    
    [Required(ErrorMessage = Constants.OrdemDeServicoClienteTelefoneErrorRequired)]
    [MaxLength(Constants.ClienteTelefoneMaxLength, ErrorMessage = Constants.ClienteTelefoneErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoClienteTelefoneDisplay)]
    public string ClienteTelefone { get; set; } = "";
    
    [Required(ErrorMessage = Constants.OrdemDeServicoVeiculoMarcaErrorRequired)]
    [MaxLength(Constants.VeiculoMarcaMaxLength, ErrorMessage = Constants.VeiculoMarcaErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoVeiculoMarcaDisplay)]
    public string VeiculoMarca { get; set; } = "";
    
    [Required(ErrorMessage = Constants.OrdemDeServicoVeiculoModeloErrorRequired)]
    [MaxLength(Constants.VeiculoModeloMaxLength, ErrorMessage = Constants.VeiculoModeloErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoVeiculoModeloDisplay)]
    public string VeiculoModelo { get; set; } = "";
    
    [Required(ErrorMessage = Constants.OrdemDeServicoVeiculoPlacaErrorRequired)]
    [MaxLength(Constants.VeiculoPlacaMaxLength, ErrorMessage = Constants.VeiculoPlacaErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoVeiculoPlacaDisplay)]
    public string VeiculoPlaca { get; set; } = "";
    
    [Required(ErrorMessage = Constants.OrdemDeServicoVeiculoAnoErrorRequired)]
    [Display(Description = Constants.OrdemDeServicoVeiculoAnoDisplay)]
    public int VeiculoAno { get; set; }
    
    [MaxLength(Constants.VeiculoCorMaxLength, ErrorMessage = Constants.VeiculoCorErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoVeiculoCorDisplay)]
    public string VeiculoCor { get; set; } = "";
    
    [Required(ErrorMessage = Constants.OrdemDeServicoServicoAreaErrorRequired)]
    [Display(Description = Constants.OrdemDeServicoServicoAreaDisplay)]
    public AreaEnum ServicoArea { get; set; } = AreaEnum.Mecanica;
    
    [Required(ErrorMessage = Constants.OrdemDeServicoServicoNomeErrorRequired)]
    [MaxLength(Constants.ServicoNomeMaxLength, ErrorMessage = Constants.ServicoNomeErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoServicoNomeDisplay)]
    public string ServicoNome { get; set; } = "";
    
    [Required(ErrorMessage = Constants.OrdemDeServicoServicoValorErrorRequired)]
    [Display(Description = Constants.OrdemDeServicoServicoValorDisplay)]
    public double ServicoValor { get; set; }
    
    [Required(ErrorMessage = Constants.OrdemDeServicoProfissionalNomeErrorRequired)]
    [MaxLength(Constants.ProfissionalNomeMaxLength, ErrorMessage = Constants.ProfissionalNomeErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoProfissionalNomeDisplay)]
    public string ProfissionalNome { get; set; } = "";
    
    [Required(ErrorMessage = Constants.OrdemDeServicoProfissionalCpfErrorRequired)]
    [MaxLength(Constants.ProfissionalCpfMaxLength, ErrorMessage = Constants.ProfissionalCpfErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoProfissionalCpfDisplay)]
    public string ProfissionalCpf { get; set; } = "";
    
    [Required(ErrorMessage = Constants.OrdemDeServicoOficinaNomeFantasiaErrorRequired)]
    [MaxLength(Constants.OficinaNomeFantasiaMaxLength, ErrorMessage = Constants.OficinaNomeFantasiaErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoOficinaNomeFantasiaDisplay)]
    public string OficinaNomeFantasia { get; set; } = "";
    
    [Required(ErrorMessage = Constants.OrdemDeServicoOficinaCnpjErrorRequired)]
    [MaxLength(Constants.OficinaCnpjMaxLength, ErrorMessage = Constants.OficinaCnpjErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoOficinaCnpjDisplay)]
    public string OficinaCnpj { get; set; } = "";
    
    [Required(ErrorMessage = Constants.OrdemDeServicoOficinaTelefoneErrorRequired)]
    [MaxLength(Constants.OficinaTelefoneMaxLength, ErrorMessage = Constants.OficinaTelefoneErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoOficinaTelefoneDisplay)]
    public string OficinaTelefone { get; set; } = "";
    
    [Required(ErrorMessage = Constants.OrdemDeServicoOficinaEmailErrorRequired)]
    [MaxLength(Constants.OficinaEmailMaxLength, ErrorMessage = Constants.OficinaEmailErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoOficinaEmailDisplay)]
    public string OficinaEmail { get; set; } = "";
    
    [Required(ErrorMessage = Constants.OrdemDeServicoOficinaNomeResponsavelErrorRequired)]
    [MaxLength(Constants.OficinaNomeResponsavelMaxLength, ErrorMessage = Constants.OficinaNomeResponsavelErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoOficinaNomeResponsavelDisplay)]
    public string OficinaNomeResponsavel { get; set; } = "";
    
    [Display(Description = Constants.OrdemDeServicoDataHoraEncerramentoDisplay)]
    public DateTime? DataHoraEncerramento { get; set; }
    
    [Display(Description = Constants.OrdemDeServicoTempoTotalDisplay)]
    public DateTime? TempoTotal { get; set; }
    
}