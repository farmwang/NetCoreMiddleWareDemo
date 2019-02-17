using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
namespace MyMiddleWarw.MiddleWare
{
    public static class UACExtensions
    {
        public static IApplicationBuilder UseUAC(this IApplicationBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            return builder.UseMiddleware<UACMiddleWare>();
        }

        public static IApplicationBuilder UseUAC(this IApplicationBuilder builder,UACOptions options)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            return builder.UseMiddleware<UACMiddleWare>(Options.Create(options));
        }
    }
}
