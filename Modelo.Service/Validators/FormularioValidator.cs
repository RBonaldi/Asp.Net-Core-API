using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    public class FormularioValidator : AbstractValidator<Formulario>
    {
        public FormularioValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possível encontrar o objeto.");
                });

            RuleFor(c => c.descricao)
                .NotEmpty().WithMessage("Descrição é obrigatoria.")
                .NotNull().WithMessage("Descrição é obrigatoria.");
        }
    }
}