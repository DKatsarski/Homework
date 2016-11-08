using CarsSystem.Data;
using CarsSystem.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.ConsoleClient
{
    class Startup
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarsSystemDbContext, Configuration>());

            var db = new CarsSystemDbContext();
            db.Cars.Count();
        }
    }
}
