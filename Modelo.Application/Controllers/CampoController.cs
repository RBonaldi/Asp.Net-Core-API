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

    public class CampoController : Controller
    {
        private CampoService service = new CampoService();
        
        [Route("Campo/GetBloco/{idGrupo}")]
        public IActionResult Get(int idGrupo)
        {
            try
            {
                return new ObjectResult(service.GetBloco(idGrupo));
            }
            catch(ArgumentException ex)
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