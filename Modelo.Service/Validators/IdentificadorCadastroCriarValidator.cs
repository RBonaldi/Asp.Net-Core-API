using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    public class IdentificadorCadastroCriarValidator : AbstractValidator<IdentificadorCadastro>
    {
        public IdentificadorCadastroCriarValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possível encontrar o objeto.");
                });

            RuleFor(c => c.criadoPor)
                .NotEmpty().WithMessage("Criado Por é obrigatorio.")
                .NotNull().WithMessage("Criado Por é obrigatorio.");
        }
    }
}