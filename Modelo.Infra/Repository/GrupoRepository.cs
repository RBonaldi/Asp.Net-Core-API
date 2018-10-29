using Modelo.Domain.Entities;
using Modelo.Domain.Interfaces;
using Modelo.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Infra.Data.Repository
{
    public class GrupoRepository : Grupo
    {
        private SqlContext context = new SqlContext();
        
        public List<Grupo> SelectBloco(int idFormulario)
        {
            List<Grupo> registro = context.Set<Grupo>().Where(r => r.idFormulario == idFormulario)
                                    .OrderBy(x => x.ordem)
                                    .ToList();

            return registro;
        }
    }
}
