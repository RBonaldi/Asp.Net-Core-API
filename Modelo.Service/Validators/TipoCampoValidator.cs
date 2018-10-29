using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    public class TipoCampoValidator : AbstractValidator<TipoCampo>
    {
        public TipoCampoValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possível encontrar o objeto.");
                });

            RuleFor(c => c.descricao)
                .NotEmpty().WithMessage("Descricao é obrigatorio.")
                .NotNull().WithMessage("Descricao é obrigatorio.");
        }
    }
}