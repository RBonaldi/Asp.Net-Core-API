using Modelo.Domain.Entities;
using Modelo.Domain.Interfaces;
using Modelo.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Infra.Data.Repository
{
    public class CampoRepository : Campo
    {
        private SqlContext context = new SqlContext();
        
        public List<Campo> SelectBloco(int idGrupo)
        {
            List<Campo> registro = context.Set<Campo>().Where(r => r.idGrupo == idGrupo)
                                    .OrderBy(x => x.ordem)
                                    .ToList();

            return registro;
        }
    }
}
