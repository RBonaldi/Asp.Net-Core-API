using Microsoft.Extensions.Configuration;
using System.ServiceModel;

namespace MRV.Solutions.Integrations.Core
{
    public abstract class ServiceBase
    {
        private readonly IConfiguration configuration;
        public EndpointAddress Endpoint { get; set; }

        public static readonly BasicHttpBinding Binding = new BasicHttpBinding
        {
            MaxReceivedMessageSize = 2147483647,
            MaxBufferSize = 2147483647
        };

        public ServiceBase(IConfiguration Configuration)
        {
            this.configuration = Configuration;
        }
    }
}
