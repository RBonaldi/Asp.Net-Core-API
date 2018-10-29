using Modelo.Domain.Entities;
using Modelo.Domain.Interfaces;
using Modelo.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Infra.Data.Repository
{
    public class IdentificadorCadastroRepository : IdentificadorCadastro
    {
        private SqlContext context = new SqlContext();

        public void Insert(IdentificadorCadastro identificadorCadastro)
        {
            identificadorCadastro.criadoEm = DateTime.Now;

            context.Set<IdentificadorCadastro>().Add(identificadorCadastro);
            context.SaveChanges();
        }

        public void Update(IdentificadorCadastro identificadorCadastro)
        {
            var registro = context.Set<IdentificadorCadastro>().First(r => r.Id == identificadorCadastro.Id);
            registro.alteradoPor = identificadorCadastro.alteradoPor;
            registro.alteradoEm = DateTime.Now;

            context.Set<IdentificadorCadastro>().Update(registro);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            IdentificadorCadastro registro = context.Set<IdentificadorCadastro>().First(r => r.Id == id);
            context.Set<IdentificadorCadastro>().Remove(registro);
            context.SaveChanges();
        }

        public IList<IdentificadorCadastro> Select()
        {
            return context.Set<IdentificadorCadastro>().ToList();
        }

        public IdentificadorCadastro Select(int id)
        {
            return context.Set<IdentificadorCadastro>().Find(id);
        }
    }
}
