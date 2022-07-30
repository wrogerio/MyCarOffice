using FluentValidation;
using MyCarOffice.Application.DTOs.Queries;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.Validations;

public class EspecializacaoValidation : AbstractValidator<EspecializacaoDto>
{
    public EspecializacaoValidation()
    {
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage(Constants.EspecializacaoNomeErrorRequired)
            .MaximumLength(Constants.EspecializacaoNomeMaxLength)
            .WithMessage(Constants.EspecializacaoNomeErrorMaxLength);

        RuleFor(x => x.Since)
            .NotNull().WithMessage(Constants.EspecializacaoNomeErrorRequired)
            .LessThan(DateTime.Now.AddYears(-1)).WithMessage(Constants.EspecializacaoSinceErrorExperience);
    }
}