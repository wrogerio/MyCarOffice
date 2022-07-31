using FluentValidation;
using MyCarOffice.Application.DTOs.OrdemDeServico;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.Validations;

public class OrdemDeServicoValidation : AbstractValidator<OrdemDeServicoDto>
{
    public OrdemDeServicoValidation()
    {
        RuleFor(x => x.DataHoraInicio)
            .NotNull().WithMessage(Constants.OrdemDeServicoDataHoraInicioErrorRequired);

        RuleFor(x => x.ClienteNome)
            .NotEmpty().WithMessage(Constants.OrdemDeServicoClienteNomeErrorRequired)
            .MaximumLength(Constants.ClienteNomeMaxLength).WithMessage(Constants.ClienteNomeErrorMaxLength);

        RuleFor(x => x.ClienteDataNasc)
            .NotNull().WithMessage(Constants.ClienteDataNascErrorRequired);

        RuleFor(x => x.ClienteCpf)
            .NotEmpty().WithMessage(Constants.ClienteCpfErrorRequired)
            .MaximumLength(Constants.ClienteCpfMaxLength).WithMessage(Constants.ClienteCpfErrorMaxLength);

        RuleFor(x => x.ClienteSexo)
            .NotEmpty().WithMessage(Constants.ClienteSexoErrorRequired)
            .MaximumLength(Constants.ClienteSexoMaxLength).WithMessage(Constants.ClienteSexoErrorMaxLength);

        RuleFor(x => x.ClienteEmail)
            .MaximumLength(Constants.ClienteEmailMaxLength).WithMessage(Constants.ClienteEmailErrorMaxLength);

        RuleFor(x => x.ClienteLogradouro)
            .NotEmpty().WithMessage(Constants.ClienteLogradouroErrorRequired)
            .MaximumLength(Constants.ClienteLogradouroMaxLength).WithMessage(Constants.ClienteLogradouroErrorMaxLength);

        RuleFor(x => x.ClienteNumero)
            .MaximumLength(Constants.ClienteNumeroMaxLength).WithMessage(Constants.ClienteNumeroErrorMaxLength);

        RuleFor(x => x.ClienteComplemento)
            .MaximumLength(Constants.ClienteComplementoMaxLength)
            .WithMessage(Constants.ClienteComplementoErrorMaxLength);

        RuleFor(x => x.ClienteBairro)
            .MaximumLength(Constants.ClienteBairroMaxLength).WithMessage(Constants.ClienteBairroErrorMaxLength);

        RuleFor(x => x.ClienteCep)
            .MaximumLength(Constants.ClienteCepMaxLength).WithMessage(Constants.ClienteCepErrorMaxLength);

        RuleFor(x => x.ClienteTelefone)
            .NotEmpty().WithMessage(Constants.ClienteTelefoneErrorRequired)
            .MaximumLength(Constants.ClienteTelefoneMaxLength).WithMessage(Constants.ClienteTelefoneErrorMaxLength);

        RuleFor(x => x.VeiculoMarca)
            .NotEmpty().WithMessage(Constants.OrdemDeServicoVeiculoMarcaErrorRequired)
            .MaximumLength(Constants.VeiculoMarcaMaxLength).WithMessage(Constants.VeiculoMarcaErrorMaxLength);

        RuleFor(x => x.VeiculoModelo)
            .NotEmpty().WithMessage(Constants.VeiculoModeloErrorRequired)
            .MaximumLength(Constants.VeiculoModeloMaxLength).WithMessage(Constants.VeiculoModeloErrorMaxLength);

        RuleFor(x => x.VeiculoPlaca)
            .NotEmpty().WithMessage(Constants.VeiculoPlacaErrorRequired)
            .MaximumLength(Constants.VeiculoPlacaMaxLength).WithMessage(Constants.VeiculoPlacaErrorMaxLength);

        RuleFor(x => x.VeiculoAno)
            .NotEmpty().WithMessage(Constants.VeiculoAnoErrorRequired);

        RuleFor(x => x.VeiculoCor)
            .MaximumLength(Constants.VeiculoCorMaxLength).WithMessage(Constants.VeiculoCorErrorMaxLength);

        RuleFor(x => x.VeiculoObservacao)
            .MaximumLength(Constants.VeiculoObservacaoMaxLength).WithMessage(Constants.VeiculoObservacaoErrorMaxLength);

        RuleFor(x => x.ServicoArea)
            .NotEmpty().WithMessage(Constants.ServicoAreaErrorRequired);

        RuleFor(x => x.ServicoNome)
            .NotEmpty().WithMessage(Constants.ServicoNomeErrorRequired)
            .MaximumLength(Constants.ServicoNomeMaxLength).WithMessage(Constants.ServicoNomeErrorMaxLength);

        RuleFor(x => x.ServicoValor)
            .NotEmpty().WithMessage(Constants.ServicoValorErrorRequired);

        RuleFor(x => x.ServicoTempoMedio)
            .NotEmpty().WithMessage(Constants.ServicoTempoMedioErrorRequired);

        RuleFor(x => x.ProfissionalNome)
            .NotEmpty().WithMessage(Constants.ProfissionalNomeErrorRequired)
            .MaximumLength(Constants.ProfissionalNomeMaxLength).WithMessage(Constants.ProfissionalNomeErrorMaxLength);

        RuleFor(x => x.ProfissionalCpf)
            .NotEmpty().WithMessage(Constants.ProfissionalCpfErrorRequired)
            .MaximumLength(Constants.ProfissionalCpfMaxLength).WithMessage(Constants.ProfissionalCpfErrorMaxLength);

        RuleFor(x => x.ProfissionalDataNasc)
            .NotNull().WithMessage(Constants.ProfissionalDataNascErrorRequired)
            .LessThan(DateTime.Now.AddYears(-18)).WithMessage(Constants.ClienteDataNascErrorAdult);

        RuleFor(x => x.ProfissionalArea)
            .NotEmpty().WithMessage(Constants.ProfissionalAreaErrorRequired);

        RuleFor(x => x.OficinaNomeFantasia)
            .NotEmpty().WithMessage(Constants.OficinaNomeFantasiaErrorRequired)
            .MaximumLength(Constants.OficinaNomeFantasiaMaxLength)
            .WithMessage(Constants.OficinaNomeFantasiaErrorMaxLength);

        RuleFor(x => x.OficinaCnpj)
            .NotEmpty().WithMessage(Constants.OficinaCnpjErrorRequired)
            .MaximumLength(Constants.OficinaCnpjMaxLength).WithMessage(Constants.OficinaCnpjErrorMaxLength);

        RuleFor(x => x.OficinaTelefone)
            .NotEmpty().WithMessage(Constants.OficinaTelefoneErrorRequired)
            .MaximumLength(Constants.OficinaTelefoneMaxLength).WithMessage(Constants.OficinaTelefoneErrorMaxLength);

        RuleFor(x => x.OficinaEmail)
            .MaximumLength(Constants.OficinaEmailMaxLength).WithMessage(Constants.OficinaEmailErrorMaxLength);

        RuleFor(x => x.OficinaNomeResponsavel)
            .NotEmpty().WithMessage(Constants.OficinaNomeResponsavelErrorRequired)
            .MaximumLength(Constants.OficinaNomeResponsavelMaxLength)
            .WithMessage(Constants.OficinaNomeResponsavelErrorMaxLength);

        RuleFor(x => x.OficinaSite)
            .MaximumLength(Constants.OficinaSiteMaxLength).WithMessage(Constants.OficinaSiteErrorMaxLength);

        RuleFor(x => x.OficinaLogradouro)
            .NotEmpty().WithMessage(Constants.OficinaLogradouroErrorRequired)
            .MaximumLength(Constants.OficinaLogradouroMaxLength).WithMessage(Constants.OficinaLogradouroErrorMaxLength);

        RuleFor(x => x.OficinaNumero)
            .MaximumLength(Constants.OficinaNumeroMaxLength).WithMessage(Constants.OficinaNumeroErrorMaxLength);

        RuleFor(x => x.OficinaComplemento)
            .MaximumLength(Constants.OficinaComplementoMaxLength)
            .WithMessage(Constants.OficinaComplementoErrorMaxLength);

        RuleFor(x => x.OficinaBairro)
            .MaximumLength(Constants.OficinaBairroMaxLength).WithMessage(Constants.OficinaBairroErrorMaxLength);

        RuleFor(x => x.OficinaCep)
            .MaximumLength(Constants.OficinaCepMaxLength).WithMessage(Constants.OficinaCepErrorMaxLength);
    }
}