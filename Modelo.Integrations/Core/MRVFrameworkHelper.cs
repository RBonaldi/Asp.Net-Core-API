namespace MRV.Terrenos.Infra.DataAgentsS.Core
{
    using Microsoft.Extensions.Configuration;
    using Seguranca;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class MRVFrameworkHelper
    {
        public MRVFrameworkHelper(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private static async Task<string> GerarTokenAsync(string apiKey)
        {
            var dateTime = await new SegurancaSoapClient(new SegurancaSoapClient.EndpointConfiguration()).GetDateTimeAsync();

            var time = BitConverter.GetBytes(dateTime.ToBinary());

            var key = new Guid(apiKey).ToByteArray();

            return Convert.ToBase64String(time.Concat(key).ToArray());
        }

        public static async Task<SegurancaSoapHeader> ValidaAcessoAsync(string apiKey, string codigoSistema)
        {
            return new SegurancaSoapHeader()
            {
                Sistema = new WsSistema()
                {
                    Codigo = Convert.ToInt32(codigoSistema),
                    Token = await GerarTokenAsync(apiKey)
                }
            };
        }
    }
}
