using Microsoft.EntityFrameworkCore;
using MyOnlyCatServer.Model;
using System;

namespace MyOnlyCatServer.Data
{
    public class MyOnlyContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Database=Best_Cats;Integrated Security=True;");
            }

            base.OnConfiguring(optionsBuilder); 
        }
    }
}
