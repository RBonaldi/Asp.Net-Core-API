using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entities
{
    public class IdentificadorCadastro : BaseEntity
    {
        public string criadoPor { get; set; }
        public string alteradoPor { get; set; }
        public DateTime? criadoEm { get; set; }
        public DateTime? alteradoEm { get; set; }
    }
}
