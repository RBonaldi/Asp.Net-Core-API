using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MRV.Solution.Core.WebApi.Extensions
{
    public static class ContextServiceExtensions
    {
        public static IServiceCollection AddContextConfiguration(this IServiceCollection services, IConfiguration Configuration)
        {
            var connectionMrvPag = Configuration.GetConnectionString("MRVPagContext");
            var connectionMrvFramework = Configuration.GetConnectionString("MRVFramworkContext");

            //services.AddDbContext<BaseContext>(b => b.UseLazyLoadingProxies(true).UseSqlServer(connectionMrvPag));
            //services.AddDbContext<MrvFrameworkContext>(b => b.UseLazyLoadingProxies(true).UseSqlServer(connectionMrvFramework));

            return services;
        }
    }
}
