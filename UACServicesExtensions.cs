using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace MyMiddleWarw.MiddleWare
{
    public static class UACServicesExtensions
    {

        public static IServiceCollection AddUAC(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            return services;
        }


        public static IServiceCollection AddUAC(this IServiceCollection services,Action<UACOptions> configureOptions)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            if (configureOptions == null)
            {
                throw new ArgumentNullException(nameof(configureOptions));
            }

            services.Configure(configureOptions);
            return services;

        }

    }
}
