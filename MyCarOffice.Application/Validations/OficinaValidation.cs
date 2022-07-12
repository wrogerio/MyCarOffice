using FluentValidation;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Helpers.Constants;

namespace MyCarOffice.Application.Validations;

public class OficinaValidation : AbstractValidator<OficinaDto>
{
    public OficinaValidation()
    {
        RuleFor(x => x.NomeFantasia)
            .NotEmpty().WithMessage(Constants.OficinaNomeFantasiaErrorRequired)
            .MaximumLength(Constants.OficinaNomeFantasiaMaxLength)
            .WithMessage(Constants.OficinaNomeFantasiaErrorMaxLength);

        RuleFor(x => x.Cnpj)
            .NotEmpty().WithMessage(Constants.OficinaCnpjErrorRequired)
            .MaximumLength(Constants.OficinaCnpjMaxLength)
            .WithMessage(Constants.OficinaCnpjErrorMaxLength);

        RuleFor(x => x.NomeResponsavel)
            .NotEmpty().WithMessage(Constants.OficinaNomeResponsavelErrorRequired)
            .MaximumLength(Constants.OficinaNomeResponsavelMaxLength)
            .WithMessage(Constants.OficinaNomeResponsavelErrorMaxLength);

        RuleFor(x => x.Telefone)
            .NotEmpty().WithMessage(Constants.OficinaTelefoneErrorRequired)
            .MaximumLength(Constants.OficinaTelefoneMaxLength)
            .WithMessage(Constants.OficinaTelefoneErrorMaxLength);

        RuleFor(x => x.Email)
            .MaximumLength(Constants.OficinaEmailMaxLength)
            .WithMessage(Constants.OficinaEmailErrorMaxLength);

        RuleFor(x => x.Logradouro)
            .NotEmpty().WithMessage(Constants.OficinaLogradouroErrorRequired)
            .MaximumLength(Constants.OficinaLogradouroMaxLength)
            .WithMessage(Constants.OficinaLogradouroErrorMaxLength);

        RuleFor(x => x.Numero)
            .MaximumLength(Constants.OficinaNumeroMaxLength)
            .WithMessage(Constants.OficinaNumeroErrorMaxLength);

        RuleFor(x => x.Complemento)
            .MaximumLength(Constants.OficinaComplementoMaxLength)
            .WithMessage(Constants.OficinaComplementoErrorMaxLength);

        RuleFor(x => x.Bairro)
            .MaximumLength(Constants.OficinaBairroMaxLength)
            .WithMessage(Constants.OficinaBairroErrorMaxLength);

        RuleFor(x => x.Cep)
            .MaximumLength(Constants.OficinaCepMaxLength)
            .WithMessage(Constants.OficinaCepErrorMaxLength);
    }
}