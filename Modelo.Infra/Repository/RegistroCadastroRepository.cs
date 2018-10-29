using Modelo.Domain.Entities;
using Modelo.Domain.Interfaces;
using Modelo.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Infra.Data.Repository
{
    public class RegistroCadastroRepository : RegistroCadastro
    {
        private SqlContext context = new SqlContext();

        public void Insert(List<RegistroCadastro> registroCadastro)
        {
            context.Set<RegistroCadastro>().AddRange(registroCadastro);
            context.SaveChanges();
        }

        public void Update(List<RegistroCadastro> registroCadastro)
        {
            foreach (var rCadastro in registroCadastro)
            {
                RegistroCadastro registro = context.Set<RegistroCadastro>().First(r => r.Id == rCadastro.Id);
                registro.valor = rCadastro.valor;

                context.Set<RegistroCadastro>().Update(registro);
            }

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            List<RegistroCadastro> registro = context.Set<RegistroCadastro>().Where(r => r.idIdentificadorCadastro == id).ToList();
            context.Set<RegistroCadastro>().RemoveRange(registro);
            context.SaveChanges();
        }

        public IList<RegistroCadastro> Select()
        {
            return context.Set<RegistroCadastro>().ToList();
        }
    }
}
