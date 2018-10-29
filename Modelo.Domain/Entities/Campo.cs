using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entities
{
    public class Campo : BaseEntity
    {
        public int idGrupo { get; set; }
        public int idTipoCampo { get; set; }
        public int ordem { get; set; }
        public bool obrigatorio { get; set; }
        public string descricao { get; set; }
        public string mascara { get; set; }
        public string fonte { get; set; }
    }
}

