using FluentValidation;
using Modelo.Domain.Entities;
using Modelo.Domain.Interfaces;
using Modelo.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Services
{
    public class CampoService : Campo
    {
        private CampoRepository repository = new CampoRepository();
        
        public List<Campo> GetBloco(int idGrupo)
        {
            return repository.SelectBloco(idGrupo);
        }

        private void Validate(Campo obj, AbstractValidator<Campo> validator) => validator.ValidateAndThrow(obj);
    }
}
