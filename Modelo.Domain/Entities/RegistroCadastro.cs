using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entities
{
    public class RegistroCadastro : BaseEntity
    {
        public int idCampo { get; set; }
        public int idIdentificadorCadastro { get; set; }
        public string valor { get; set; }
    }
}
