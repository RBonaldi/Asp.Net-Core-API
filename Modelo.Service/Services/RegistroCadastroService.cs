using FluentValidation;
using Modelo.Domain.Entities;
using Modelo.Domain.Interfaces;
using Modelo.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Services
{
    public class RegistroCadastroService : RegistroCadastro
    {
        private RegistroCadastroRepository repository = new RegistroCadastroRepository();
        
        public List<RegistroCadastro> Post<V>(List<RegistroCadastro> obj) where V : AbstractValidator<RegistroCadastro>
        {
            repository.Insert(obj);
            return obj;
        }

        public List<RegistroCadastro> Put<V>(List<RegistroCadastro> obj) where V : AbstractValidator<RegistroCadastro>
        {
            repository.Update(obj);
            return obj;
        }

        public void Delete(int id) => repository.Delete(id);

        public IList<RegistroCadastro> Get() => repository.Select();

        private void Validate(RegistroCadastro obj, AbstractValidator<RegistroCadastro> validator) => validator.ValidateAndThrow(obj);
    }
}
