using FluentValidation;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.Validations;

public class VeiculoValidation : AbstractValidator<VeiculoDto>
{
    public VeiculoValidation()
    {
        RuleFor(x => x.Marca)
            .NotEmpty().WithMessage(Constants.VeiculoMarcaErrorRequired)
            .MaximumLength(Constants.VeiculoMarcaMaxLength).WithMessage(Constants.VeiculoMarcaErrorMaxLength);

        RuleFor(x => x.Modelo)
            .NotEmpty().WithMessage(Constants.VeiculoModeloErrorRequired)
            .MaximumLength(Constants.VeiculoModeloMaxLength).WithMessage(Constants.VeiculoModeloErrorMaxLength);

        RuleFor(x => x.Placa)
            .NotEmpty().WithMessage(Constants.VeiculoPlacaErrorRequired)
            .MaximumLength(Constants.VeiculoPlacaMaxLength).WithMessage(Constants.VeiculoPlacaErrorMaxLength);

        RuleFor(x => x.Ano)
            .NotEmpty().WithMessage(Constants.VeiculoAnoErrorRequired);

        RuleFor(x => x.Cor)
            .MaximumLength(Constants.VeiculoCorMaxLength).WithMessage(Constants.VeiculoCorErrorMaxLength);

        RuleFor(x => x.Observacao)
            .MaximumLength(Constants.VeiculoObservacaoMaxLength).WithMessage(Constants.VeiculoObservacaoErrorMaxLength);
    }
}