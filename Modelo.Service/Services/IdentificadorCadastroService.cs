using FluentValidation;
using Modelo.Domain.Entities;
using Modelo.Domain.Interfaces;
using Modelo.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Service.Services
{
    public class IdentificadorCadastroService : IdentificadorCadastro
    {
        private IdentificadorCadastroRepository repository = new IdentificadorCadastroRepository();
        
        public int Post<V>(string criadoPor) where V : AbstractValidator<IdentificadorCadastro>
        {
            IdentificadorCadastro identificadorCadastro = new IdentificadorCadastro();
            identificadorCadastro.criadoPor = criadoPor;

            Validate(identificadorCadastro, Activator.CreateInstance<V>());

            repository.Insert(identificadorCadastro);
            return identificadorCadastro.Id;
        }

        public int Put<V>(string alteradoPor, int idRegistro) where V : AbstractValidator<IdentificadorCadastro>
        {
            IdentificadorCadastro identificadorCadastro = new IdentificadorCadastro();
            identificadorCadastro.Id = idRegistro;
            identificadorCadastro.alteradoPor = alteradoPor;

            Validate(identificadorCadastro, Activator.CreateInstance<V>());

            repository.Update(identificadorCadastro);
            return identificadorCadastro.Id;
        }

        public void Delete(int id) => repository.Delete(id);

        public IList<IdentificadorCadastro> Get() => repository.Select();

        public IdentificadorCadastro Get(int id)
        {
            return repository.Select(id);
        }

        private void Validate(IdentificadorCadastro obj, AbstractValidator<IdentificadorCadastro> validator) => validator.ValidateAndThrow(obj);
    }
}
