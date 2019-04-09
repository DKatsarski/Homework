using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsServer.Data
{
    public class CatsDbContext : DbContext
    {

        public DbSet<Cat> Cats { get; set; }

       


    }
}
