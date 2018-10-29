using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    public class GrupoValidator : AbstractValidator<Grupo>
    {
        public GrupoValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possível encontrar o objeto.");
                });

            RuleFor(c => c.idFormulario)
                .NotEmpty().WithMessage("IdFormulario é obrigatorio.")
                .NotNull().WithMessage("IdFormulario é obrigatorio.");

            RuleFor(c => c.ordem)
                .NotEmpty().WithMessage("Ordem é obrigatoria.")
                .NotNull().WithMessage("Ordem é obrigatoria.");

            RuleFor(c => c.descricao)
                .NotEmpty().WithMessage("Descrição é obrigatoria.")
                .NotNull().WithMessage("Descrição é obrigatoria.");
        }
    }
}