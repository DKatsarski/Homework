namespace StudentSystem.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StudentDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.ContextKey = "StudentSystem.Data.StudentDbContext";
        }

        protected override void Seed(StudentDbContext context)
        {
            context
                 .Students
                 .AddOrUpdate(
                s => s.Name,
                new Student
                {
                    Name = "Seeded Pesho"
                },
                new Student
                {
                    Name = "Seeded Gosho"
                });
        }
    }
}
