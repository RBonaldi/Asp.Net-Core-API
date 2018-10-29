using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.Domain.Entities;
using Modelo.Service.Services;
using Modelo.Service.Validators;

namespace Modelo.Application.Controllers
{
    [Produces("application/json")]

    public class GrupoController : Controller
    {
        private GrupoService service = new GrupoService();
        
        [Route("Grupo/GetBloco/{idFormulario}")]
        public IActionResult GetBloco(int idFormulario)
        {
            try
            {
                return new ObjectResult(service.GetBloco(idFormulario));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}