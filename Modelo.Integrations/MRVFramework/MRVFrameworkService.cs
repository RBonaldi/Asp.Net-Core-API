
using Microsoft.Extensions.Configuration;
using MRV.Solution.Identity.Models;
using MRV.Solution.Identity.Services;
using MRV.Terrenos.Infra.DataAgentsS.Core;
using Seguranca;
using System;
using System.Security.Authentication;
using System.ServiceModel;
using System.Threading.Tasks;

namespace MRV.Terrenos.Infra.DataAgentsS.MRVFramework
{
    public class MRVFrameworkService : IMRVFrameworkService
    {
        public MRVFrameworkService(IConfiguration configuration)
        {
            Configuration = configuration;
            Endpoint = new EndpointAddress(Configuration["MRVFramework:URL"]);
        }

        public IConfiguration Configuration { get; }
        private EndpointAddress Endpoint { get; }
        private static readonly BasicHttpBinding Binding = new BasicHttpBinding
        {
            MaxReceivedMessageSize = 2147483647,
            MaxBufferSize = 2147483647
        };

        public async Task<User> ValidarSenha(string login, string senha)
        {
            UsuarioValidarResponse usuarioValidarResponse;
            User usuario = new User();
            using (var proxy = new GenericProxy<SegurancaSoap>(Binding, Endpoint))
            {
                try
                {
                    var usuariovalidar = new UsuarioValidarRequest
                    {
                        login = login,
                        senha = senha,
                        SegurancaSoapHeader = await MRVFrameworkHelper.ValidaAcessoAsync(Configuration["MRVFramework:ApiKey"], Configuration["MRVFramework:CodigoSistema"])
                    };

                    usuarioValidarResponse = await proxy.Execute(c => c.UsuarioValidarAsync(usuariovalidar));

                    usuario = new User()
                    {
                        Name = usuarioValidarResponse.UsuarioValidarResult.Nome,
                        Login = usuarioValidarResponse.UsuarioValidarResult.Login,
                        Email = usuarioValidarResponse.UsuarioValidarResult.Email
                    };

                    foreach (var grupo in usuarioValidarResponse.UsuarioValidarResult.Grupos)
                    {
                        usuario.Profile = grupo.Nome;
                        usuario.ProfileCode = grupo.Codigo;
                    }
                }
                catch (FaultException faultException)
                {
                    throw new Exception("Acesso Inválido");
                }
                catch (Exception ex)
                {
                    if (ex.Message.IndexOf("Logon failure: unknown user name or bad password", StringComparison.Ordinal) != -1)
                        throw new Exception("Acesso Inválido");

                    else if (ex.Message.IndexOf("#E20", StringComparison.Ordinal) != -1 || ex.Message.IndexOf("#E21", StringComparison.Ordinal) != -1)
                        throw new Exception("Acesso Inválido");

                    else
                        throw new Exception("Acesso Inválido");
                }

                return usuario;
            }
        }

        public async Task<User> ValidarLogin(string login)
        {
            UsuarioValidarPorLoginResponse usuarioValidarResponse;
            User usuario = new User();
            using (var proxy = new GenericProxy<SegurancaSoap>(Binding, Endpoint))
            {
                try
                {
                    var usuariovalidar = new UsuarioValidarPorLoginRequest
                    {
                        login = login,
                        SegurancaSoapHeader = await MRVFrameworkHelper.ValidaAcessoAsync(Configuration["MRVFramework:ApiKey"], Configuration["MRVFramework:CodigoSistema"])
                    };

                    usuarioValidarResponse = await proxy.Execute(c => c.UsuarioValidarPorLoginAsync(usuariovalidar));

                    usuario = new User()
                    {
                        Name = usuarioValidarResponse.UsuarioValidarPorLoginResult.Nome,
                        Login = usuarioValidarResponse.UsuarioValidarPorLoginResult.Login,
                        Email = usuarioValidarResponse.UsuarioValidarPorLoginResult.Email
                    };

                    foreach (var grupo in usuarioValidarResponse.UsuarioValidarPorLoginResult.Grupos)
                    {
                        usuario.Profile = grupo.Nome;
                        usuario.ProfileCode = grupo.Codigo;
                    }
                }
                catch (FaultException) { }
                catch (Exception ex)
                {
                    if (ex.Message.IndexOf("Logon failure: unknown user name or bad password", StringComparison.Ordinal) != -1)
                        throw new AuthenticationException(Messages.Message.ErroLoginSenhaIncorretos);

                    else if (ex.Message.IndexOf("#E20", StringComparison.Ordinal) != -1 || ex.Message.IndexOf("#E21", StringComparison.Ordinal) != -1)
                        throw new AuthenticationException(Messages.Message.ErroLoginSenhaIncorretos);

                    else
                        throw new AuthenticationException(Messages.Message.ErroDesconhecido);
                }

                return usuario;
            }
        }
    }
}