using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatsServer.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;



namespace CatsServer
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CatsDbContext>(options =>
            options.UseSqlServer("Server=.;Database=CatsServerDb;Integrated Security=True;"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Use((context, next) =>
            {
                context.RequestServices.GetRequiredService<CatsDbContext>().Database.Migrate();
                return next();
            });

            app.Use((context, next) =>
            {
                context.Request.Headers.Add("Content-Type", "text/html");
                return next();
            });

            app.MapWhen(
                ctx => ctx.Request.Path.Value == "/"
                && ctx.Request.Method == "GET",
                home =>
                {
                    home.Run(async (context) =>
                        {
                            await context.Response.WriteAsync($"<h1>{env.ApplicationName}</h1>");

                            var db = context.RequestServices.GetRequiredService<CatsDbContext>();

                            var catData = db
                            .Cats
                            .Select(c => new
                            {
                                c.Id,
                                c.Name
                            })
                            .ToList();

                            await context.Response.WriteAsync("<ul>");

                            foreach (var cat in catData)
                            {
                                await context.Response.WriteAsync($@"<li><a href=""/cat/{cat.Id}"">{cat.Name}</li>");
                            }

                            await context.Response.WriteAsync("</ul>");
                            await context.Response.WriteAsync(@" <form action=""cat/add"">
                                                                    <input type=""submit"" value=""Add Cat"" />
                                                                </form>");

                        });
                });


            app.Run(async (context) =>
            {

                context.Response.StatusCode = 404;
                await context.Response.WriteAsync("404 Page Was Not Found :/");
            });
        }
    }
}
