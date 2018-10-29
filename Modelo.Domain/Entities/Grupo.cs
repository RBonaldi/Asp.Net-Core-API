using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entities
{
    public class Grupo : BaseEntity
    {
        public int idFormulario { get; set; }
        public int ordem { get; set; }
        public string descricao { get; set; }
    }
}

