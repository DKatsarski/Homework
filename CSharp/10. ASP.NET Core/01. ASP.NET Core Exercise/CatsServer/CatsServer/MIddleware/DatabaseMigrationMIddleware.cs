using CatsServer.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace CatsServer.MIddleware
{
    public class DatabaseMigrationMIddleware
    {
        private readonly RequestDelegate next;

        public DatabaseMigrationMIddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext context)
        {
            context.RequestServices.GetRequiredService<CatsDbContext>().Database.Migrate();
            return this.next(context);
        }
    }
}
