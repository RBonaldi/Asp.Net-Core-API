using FluentValidation;
using Modelo.Domain.Entities;
using Modelo.Domain.Interfaces;
using Modelo.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Services
{
    public class GrupoService : Grupo
    {
        private GrupoRepository repository = new GrupoRepository();
        
        public List<Grupo> GetBloco(int idFormulario)
        {
            return repository.SelectBloco(idFormulario);
        }

        private void Validate(Grupo obj, AbstractValidator<Grupo> validator) => validator.ValidateAndThrow(obj);
    }
}
