using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    public class IdentificadorCadastroAlterarValidator : AbstractValidator<IdentificadorCadastro>
    {
        public IdentificadorCadastroAlterarValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possível encontrar o objeto.");
                });

            RuleFor(c => c.alteradoPor)
                .NotEmpty().WithMessage("Alterado Por é obrigatorio.")
                .NotNull().WithMessage("Alterado Por é obrigatorio.");
        }
    }
}