using System;
using System.Linq;
using CatsServer.Data;
using CatsServer.Infrastructure;
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

            app.UseStaticFiles();

            app.Use((context, next) =>
            {
                context.Response.Headers.Add("Content-Type", "text/html");
                return next();
            });

            app.MapWhen(
                ctx => ctx.Request.Path.Value == "/"
                && ctx.Request.Method == HttpMethod.Get,
                home =>
                {
                    home.Run(async (context) =>
                        {
                            await context.Response.WriteAsync($"<h1>{env.ApplicationName}</h1>");

                            var db = context.RequestServices.GetRequiredService<CatsDbContext>();

                            using (db)
                            {
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
                                await context.Response.WriteAsync(@" <form action=""/cat/add"">
                                                                    <input type=""submit"" value=""Add Cat"" />
                                                                </form>");
                            }
                        });
                });


            app.MapWhen(ctx => ctx.Request.Path.Value == "/cat/add",

            catAdd =>
            {
                catAdd.Run(async (context) =>
                {
                    if (context.Request.Method == HttpMethod.Get)
                    {
                        context.Response.Redirect("/cats-add-form.html");

                    }
                    else if (context.Request.Method == HttpMethod.Post)
                    {
                        var formData = context.Request.Form;

                        var age = 0;

                        int.TryParse(formData["Age"], out age);

                        var cat = new Cat
                        {
                            Name = formData["Name"],
                            Age = age,
                            Breed = formData["Breed"],
                            ImageUrl = formData["ImageUrl"]

                        };

                        try
                        {
                            if (string.IsNullOrWhiteSpace(cat.Name)
                            || string.IsNullOrWhiteSpace(cat.Breed)
                            || string.IsNullOrWhiteSpace(cat.ImageUrl))
                            {
                                throw new InvalidOperationException("Invalid cat data.");
                            }

                            var db = context.RequestServices.GetRequiredService<CatsDbContext>();

                            using (db)
                            {
                                db.Add(cat);

                                await db.SaveChangesAsync();
                            }

                            context.Response.Redirect("/");
                        }
                        catch (Exception)
                        {

                            await context.Response.WriteAsync("<h2>Invalid cat data!</h2>");
                            await context.Response.WriteAsync(@"<a href=""/cat/add"">Back To The Form</a>");
                        }
                    }
                });
            });

            app.MapWhen(ctx => ctx.Request.Path.Value.StartsWith("/cat")
            && ctx.Request.Method == HttpMethod.Get,
            catDetails =>
            {
                catDetails.Run(async (context) =>
                {
                    var urlParts = context.Request.Path.Value.Split("/", StringSplitOptions.RemoveEmptyEntries);

                    if (urlParts.Length < 2)
                    {
                        context.Response.Redirect("/");
                        return;
                    }

                    var catId = 0;
                    int.TryParse(urlParts[1], out catId);

                    if (catId == 0)
                    {
                        context.Response.Redirect("/");
                        return;
                    }

                    var db = context.RequestServices.GetRequiredService<CatsDbContext>();

                    using (db)
                    {
                        var cat = await db.Cats.FindAsync(catId);

                        if (cat == null)
                        {
                            context.Response.Redirect("/");
                            return;
                        }

                        await context.Response.WriteAsync($"<h1>{cat.Name}</h1>");
                        await context.Response.WriteAsync($@"<img src=""{cat.ImageUrl}"" alt=""{cat.Name}"" width=""300""/>");
                        await context.Response.WriteAsync($"<p><b>Age: {cat.Age}</b></p>");
                        await context.Response.WriteAsync($"<p><b>Breed: {cat.Breed}</b></p>");
                    }
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
