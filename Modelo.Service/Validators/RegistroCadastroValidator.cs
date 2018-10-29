using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    public class RegistroCadastroValidator : AbstractValidator<RegistroCadastro>
    {
        public RegistroCadastroValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possível encontrar o objeto.");
                });

            RuleFor(c => c.idCampo)
                .NotEmpty().WithMessage("IdCampo é obrigatorio.")
                .NotNull().WithMessage("IdCampo é obrigatorio.");

            RuleFor(c => c.idIdentificadorCadastro)
                .NotEmpty().WithMessage("IdIdentificadorCadastro são obrigatorios.")
                .NotNull().WithMessage("IdIdentificadorCadastro são obrigatorios.");

            RuleFor(c => c.valor)
                .NotEmpty().WithMessage("Valor são obrigatorios.")
                .NotNull().WithMessage("Valor são obrigatorios.");
        }
    }
}