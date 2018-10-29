using FluentValidation;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Validators
{
    public class CampoValidator : AbstractValidator<Campo>
    {
        public CampoValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não foi possível encontrar o objeto.");
                });

            RuleFor(c => c.idGrupo)
                .NotEmpty().WithMessage("IdGrupo é obrigatorio.")
                .NotNull().WithMessage("IdGrupo é obrigatorio.");

            RuleFor(c => c.idTipoCampo)
                .NotEmpty().WithMessage("IdTipoCampo é obrigatorio.")
                .NotNull().WithMessage("IdTipoCampo é obrigatorio.");

            RuleFor(c => c.ordem)
                .NotEmpty().WithMessage("Ordem é obrigatorio.")
                .NotNull().WithMessage("Ordem é obrigatorio.");

            RuleFor(c => c.obrigatorio)
                .NotEmpty().WithMessage("O campo obrigatorio deve ser preenchido.")
                .NotNull().WithMessage("O campo obrigatorio deve ser preenchido.");

            RuleFor(c => c.descricao)
                .NotEmpty().WithMessage("Descrição é obrigatoria.")
                .NotNull().WithMessage("Descrição é obrigatoria.");
        }
    }
}