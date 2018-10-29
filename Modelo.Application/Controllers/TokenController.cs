using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MRV.Solution.Core.WebApi.Security;
using MRV.Solution.Identity.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MRV.Solution.Core.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : Controller
    {
        [AllowAnonymous]
        [HttpPost]
        public object Post(
           [FromBody]Security.User usuario,
           [FromServices]IMRVFrameworkService frameworkService,
           [FromServices]SigningConfigurations signingConfigurations,
           [FromServices]TokenConfigurations tokenConfigurations)
        {
            
            var usuarioBase = new Identity.Models.User();
            if (usuario != null && !String.IsNullOrWhiteSpace(usuario.username))
            {
                var task = Task.Run(async () => await frameworkService.ValidarSenha(usuario.username, usuario.password));
                task.Wait();
                usuarioBase = task.Result;
            }

            if (usuarioBase != null && usuarioBase.Login != null)
            {
                ClaimsIdentity identity = new ClaimsIdentity(new List<Claim> {
                    new Claim(ClaimTypes.NameIdentifier, usuarioBase.Login),
                    new Claim(ClaimTypes.Name, usuarioBase.Name),
                    new Claim(ClaimTypes.Email, usuarioBase.Email),
                    new Claim("Perfil", usuarioBase.Profile),
                    new Claim("CodigoPerfil", usuarioBase.ProfileCode.ToString())});

                DateTime dataCriacao = DateTime.Now;
                DateTime dataExpiracao = DateTime.Now;

                switch (tokenConfigurations.ExpirationType)
                {
                    case "Seconds":
                        dataExpiracao = dataCriacao + TimeSpan.FromSeconds(tokenConfigurations.Seconds);
                        break;
                    case "Minutes":
                        dataExpiracao = dataCriacao + TimeSpan.FromMinutes(tokenConfigurations.Minutes);
                        break;
                    case "Days":
                        dataExpiracao = dataCriacao + TimeSpan.FromDays(tokenConfigurations.Days);
                        break;
                    default:
                        break;
                }

                var handler = new JwtSecurityTokenHandler();
                var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                {
                    Issuer = tokenConfigurations.Issuer,
                    Audience = tokenConfigurations.Audience,
                    SigningCredentials = signingConfigurations.SigningCredentials,
                    Subject = identity,
                    NotBefore = dataCriacao,
                    Expires = dataExpiracao
                });
                var token = handler.WriteToken(securityToken);

                

                return new
                {
                    authenticated = true,
                    accessToken = token,
                    login = usuario.username,
                    firstName  = usuarioBase.Name.Split(' ').FirstOrDefault(),
                    usuario = usuarioBase
                };
            }
            else
            {
                return new
                {
                    authenticated = false,
                    message = "Falha ao autenticar"
                };
            }
        }
    }
}
