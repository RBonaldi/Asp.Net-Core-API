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

    public class RegistroCadastroController : Controller
    {
        private IdentificadorCadastroService serviceIdentificador = new IdentificadorCadastroService();
        private RegistroCadastroService serviceRegistro = new RegistroCadastroService();
        
        [Route("RegistroCadastro/Post/{criadoPor}")]
        [HttpPost]
        public IActionResult Post(string criadoPor, [FromBody] RegistroCadastro registroCadastro)
        {
            try
            {
                int idIdentificadorCadastro = serviceIdentificador.Post<IdentificadorCadastroCriarValidator>(criadoPor);

                //fake
                    var a = new RegistroCadastro
                    {
                        idCampo = 1,
                        idIdentificadorCadastro = idIdentificadorCadastro,
                        valor = "tese"
                    };
                    var b = new RegistroCadastro
                    {
                        idCampo = 2,
                        idIdentificadorCadastro = idIdentificadorCadastro,
                        valor = "tst tst"
                    };

                    List<RegistroCadastro> RC = new List<RegistroCadastro>();
                    RC.Add(a);
                    RC.Add(b);
                //fake

                serviceRegistro.Post<RegistroCadastroValidator>(RC);

                return new ObjectResult(idIdentificadorCadastro);
            }
            catch(ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("RegistroCadastro/Put/{alteradoPor}/{idRegistro}")]
        public IActionResult Put(string alteradoPor, int idRegistro, [FromBody] RegistroCadastro registroCadastro)
        {
            try
            {
                int idIdentificadorCadastro = serviceIdentificador.Put<IdentificadorCadastroAlterarValidator>(alteradoPor, idRegistro);

                //fake
                var a = new RegistroCadastro
                {
                    Id = 3,
                    idCampo = 1,
                    idIdentificadorCadastro = idIdentificadorCadastro,
                    valor = "tese 2"
                };
                var b = new RegistroCadastro
                {
                    Id = 4,
                    idCampo = 2,
                    idIdentificadorCadastro = idIdentificadorCadastro,
                    valor = "tst tst 2"
                };

                List<RegistroCadastro> RC = new List<RegistroCadastro>();
                RC.Add(a);
                RC.Add(b);
                //fake

                serviceRegistro.Put<RegistroCadastroValidator>(RC);
                
                return new ObjectResult(idIdentificadorCadastro);
            }
            catch(ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("RegistroCadastro/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                serviceRegistro.Delete(id);
                serviceIdentificador.Delete(id);

                return new NoContentResult();
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

        [Route("RegistroCadastro/GET")]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(serviceRegistro.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("RegistroCadastro/GET/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(serviceIdentificador.Get(id));
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