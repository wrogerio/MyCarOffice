using FluentValidation;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.Validations;

public class ClienteValidation : AbstractValidator<ClienteDto>
{
    public ClienteValidation()
    {
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage(Constants.ClienteNomeErrorRequired)
            .MaximumLength(Constants.ClienteNomeMaxLength).WithMessage(Constants.ClienteNomeErrorMaxLength);

        RuleFor(x => x.Cpf)
            .NotEmpty().WithMessage(Constants.ClienteNomeErrorRequired)
            .MaximumLength(Constants.ClienteNomeMaxLength).WithMessage(Constants.ClienteNomeErrorMaxLength);

        RuleFor(x => x.DataNasc)
            .NotNull().WithMessage(Constants.ClienteDataNascErrorRequired)
            .LessThan(DateTime.Now.AddYears(-18)).WithMessage(Constants.ClienteDataNascErrorAdult);

        RuleFor(x => x.Telefone)
            .NotEmpty().WithMessage(Constants.ClienteTelefoneErrorRequired)
            .MaximumLength(Constants.ClienteTelefoneMaxLength).WithMessage(Constants.ClienteTelefoneErrorMaxLength);

        RuleFor(x => x.Email)
            .MaximumLength(Constants.ClienteEmailMaxLength).WithMessage(Constants.ClienteEmailErrorMaxLength);

        RuleFor(x => x.Sexo)
            .NotEmpty().WithMessage(Constants.ClienteSexoErrorRequired)
            .MaximumLength(Constants.ClienteSexoMaxLength).WithMessage(Constants.ClienteSexoErrorMaxLength);

        RuleFor(x => x.Logradouro)
            .NotEmpty().WithMessage(Constants.ClienteLogradouroErrorRequired)
            .MaximumLength(Constants.ClienteLogradouroMaxLength).WithMessage(Constants.ClienteLogradouroErrorMaxLength);

        RuleFor(x => x.Numero)
            .MaximumLength(Constants.ClienteNumeroMaxLength).WithMessage(Constants.ClienteNumeroErrorMaxLength);

        RuleFor(x => x.Complemento)
            .MaximumLength(Constants.ClienteComplementoMaxLength)
            .WithMessage(Constants.ClienteComplementoErrorMaxLength);

        RuleFor(x => x.Bairro)
            .MaximumLength(Constants.ClienteBairroMaxLength).WithMessage(Constants.ClienteBairroErrorMaxLength);

        RuleFor(x => x.Cep)
            .MaximumLength(Constants.ClienteCepMaxLength).WithMessage(Constants.ClienteCepErrorMaxLength);
    }
}