using FluentValidation;
using MyCarOffice.Application.DTOs.Profissional;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.Validations;

public class ProfissionalValidation : AbstractValidator<ProfissionalDto>
{
    public ProfissionalValidation()
    {
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage(Constants.ProfissionalNomeErrorRequired)
            .MaximumLength(Constants.ProfissionalNomeMaxLength).WithMessage(Constants.ProfissionalNomeErrorMaxLength);

        RuleFor(x => x.Cpf)
            .NotEmpty().WithMessage(Constants.ProfissionalCpfErrorRequired)
            .MaximumLength(Constants.ProfissionalCpfMaxLength).WithMessage(Constants.ProfissionalCpfErrorMaxLength);

        RuleFor(x => x.DataNasc)
            .NotEmpty().WithMessage(Constants.ProfissionalDataNascErrorRequired)
            .LessThan(DateTime.Now.AddYears(-18)).WithMessage(Constants.ClienteDataNascErrorAdult);

        RuleFor(x => x.Area)
            .NotEmpty().WithMessage(Constants.ProfissionalAreaErrorRequired);
    }
}