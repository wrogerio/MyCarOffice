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

    [Required(ErrorMessage = Constants.OrdemDeServicoClienteDataNascErrorRequired)]
    [Display(Description = Constants.OrdemDeServicoClienteDataNascDisplay)]
    public DateTime ClienteDataNasc { get; set; }

    [Required(ErrorMessage = Constants.OrdemDeServicoClienteCpfErrorRequired)]
    [MaxLength(Constants.ClienteCpfMaxLength, ErrorMessage = Constants.ClienteCpfErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoClienteCpfDisplay)]
    public string ClienteCpf { get; set; } = "";

    [Required(ErrorMessage = Constants.OrdemDeServicoClienteSexoErrorRequired)]
    [MaxLength(Constants.ClienteSexoMaxLength, ErrorMessage = Constants.ClienteSexoErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoClienteSexoDisplay)]
    public string ClienteSexo { get; set; } = "";

    [MaxLength(Constants.ClienteEmailMaxLength, ErrorMessage = Constants.ClienteEmailErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoClienteEmailDisplay)]
    public string ClienteEmail { get; set; } = "";

    [Required(ErrorMessage = Constants.OrdemDeServicoClienteLogradouroErrorRequired)]
    [MaxLength(Constants.ClienteLogradouroMaxLength, ErrorMessage = Constants.ClienteLogradouroErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoClienteLogradouroDisplay)]
    public string ClienteLogradouro { get; set; } = "";

    [MaxLength(Constants.ClienteNumeroMaxLength, ErrorMessage = Constants.ClienteNumeroErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoClienteNumeroDisplay)]
    public string ClienteNumero { get; set; } = "";

    [MaxLength(Constants.ClienteComplementoMaxLength, ErrorMessage = Constants.ClienteComplementoErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoClienteComplementoDisplay)]
    public string ClienteComplemento { get; set; } = "";

    [MaxLength(Constants.ClienteBairroMaxLength, ErrorMessage = Constants.ClienteBairroErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoClienteBairroDisplay)]
    public string ClienteBairro { get; set; } = "";

    [MaxLength(Constants.ClienteCepMaxLength, ErrorMessage = Constants.ClienteCepErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoClienteCepDisplay)]
    public string ClienteCep { get; set; } = "";

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

    [MaxLength(Constants.VeiculoCorMaxLength, ErrorMessage = Constants.VeiculoObservacaoErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoVeiculoObservacaoDisplay)]
    public string VeiculoObservacao { get; set; } = "";

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

    [Required(ErrorMessage = Constants.OrdemDeServicoServicoTempoMedioErrorRequired)]
    [Display(Description = Constants.OrdemDeServicoServicoTempoMedioDisplay)]
    public double ServicoTempoMedio { get; set; }

    [Required(ErrorMessage = Constants.OrdemDeServicoProfissionalNomeErrorRequired)]
    [MaxLength(Constants.ProfissionalNomeMaxLength, ErrorMessage = Constants.ProfissionalNomeErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoProfissionalNomeDisplay)]
    public string ProfissionalNome { get; set; } = "";

    [Required(ErrorMessage = Constants.OrdemDeServicoProfissionalCpfErrorRequired)]
    [MaxLength(Constants.ProfissionalCpfMaxLength, ErrorMessage = Constants.ProfissionalCpfErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoProfissionalCpfDisplay)]
    public string ProfissionalCpf { get; set; } = "";

    [Required(ErrorMessage = Constants.OrdemDeServicoProfissionalDataNascErrorRequired)]
    [Display(Description = Constants.OrdemDeServicoProfissionalDataNascDisplay)]
    public DateTime ProfissionalDataNasc { get; set; }

    [Required(ErrorMessage = Constants.OrdemDeServicoProfissionalAreaErrorRequired)]
    [Display(Description = Constants.OrdemDeServicoProfissionalAreaDisplay)]
    public int ProfissionalArea { get; set; }

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

    [MaxLength(Constants.OficinaEmailMaxLength, ErrorMessage = Constants.OficinaEmailErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoOficinaEmailDisplay)]
    public string OficinaEmail { get; set; } = "";

    [Required(ErrorMessage = Constants.OrdemDeServicoOficinaNomeResponsavelErrorRequired)]
    [MaxLength(Constants.OficinaNomeResponsavelMaxLength,
        ErrorMessage = Constants.OficinaNomeResponsavelErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoOficinaNomeResponsavelDisplay)]
    public string OficinaNomeResponsavel { get; set; } = "";

    [MaxLength(Constants.OficinaSiteMaxLength, ErrorMessage = Constants.OficinaSiteErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoOficinaSiteDisplay)]
    public string OficinaSite { get; set; } = "";

    [Required(ErrorMessage = Constants.OrdemDeServicoOficinaLogradouroErrorRequired)]
    [MaxLength(Constants.OficinaLogradouroMaxLength, ErrorMessage = Constants.OficinaLogradouroErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoOficinaLogradouroDisplay)]
    public string OficinaLogradouro { get; set; } = "";

    [MaxLength(Constants.OficinaNumeroMaxLength, ErrorMessage = Constants.OficinaNumeroErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoOficinaNumeroDisplay)]
    public string OficinaNumero { get; set; } = "";

    [MaxLength(Constants.OficinaComplementoMaxLength, ErrorMessage = Constants.OficinaComplementoErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoOficinaComplementoDisplay)]
    public string OficinaComplemento { get; set; } = "";

    [MaxLength(Constants.OficinaBairroMaxLength, ErrorMessage = Constants.OficinaBairroErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoOficinaBairroDisplay)]
    public string OficinaBairro { get; set; } = "";

    [MaxLength(Constants.OficinaCepMaxLength, ErrorMessage = Constants.OficinaCepErrorMaxLength)]
    [Display(Description = Constants.OrdemDeServicoOficinaCepDisplay)]
    public string OficinaCep { get; set; } = "";

    [Display(Description = Constants.OrdemDeServicoDataHoraEncerramentoDisplay)]
    public DateTime? DataHoraEncerramento { get; set; }

    [Display(Description = Constants.OrdemDeServicoTempoTotalDisplay)]
    public DateTime? TempoTotal { get; set; }
}