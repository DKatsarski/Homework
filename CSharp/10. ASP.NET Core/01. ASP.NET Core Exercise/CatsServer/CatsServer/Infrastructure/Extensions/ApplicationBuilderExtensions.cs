using CatsServer.MIddleware;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsServer.Infrastructure.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseDatabaseMIgration(
            this IApplicationBuilder builder)
                => builder.UseMiddleware<DatabaseMigrationMIddleware>();

        public static IApplicationBuilder UseHtmlContentType(
          this IApplicationBuilder builder)
              => builder.UseMiddleware<HtmlContentTypeMiddleware>();

    }
}
