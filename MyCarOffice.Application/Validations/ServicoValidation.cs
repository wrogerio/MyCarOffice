using FluentValidation;
using MyCarOffice.Application.DTOs.Queries;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.Validations;

public class ServicoValidation : AbstractValidator<ServicoDto>
{
    public ServicoValidation()
    {
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage(Constants.ServicoNomeErrorRequired)
            .MaximumLength(Constants.ServicoNomeMaxLength).WithMessage(Constants.ServicoNomeErrorMaxLength);

        RuleFor(x => x.Area)
            .NotEmpty().WithMessage(Constants.ServicoAreaErrorRequired);

        RuleFor(x => x.Valor)
            .NotEmpty().WithMessage(Constants.ServicoValorErrorRequired);

        RuleFor(x => x.TempoMedio)
            .NotEmpty().WithMessage(Constants.ServicoTempoMedioErrorRequired);
    }
}