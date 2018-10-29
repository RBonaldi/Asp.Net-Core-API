using System;
using Microsoft.Extensions.DependencyInjection;
using MRV.Solution.Identity.Services;
using MRV.Terrenos.Infra.DataAgentsS.MRVFramework;

namespace MRV.Solution.IoC
{
    public abstract class NativeBootStrapperBase
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IMRVFrameworkService, MRVFrameworkService>();
        }
    }
}
