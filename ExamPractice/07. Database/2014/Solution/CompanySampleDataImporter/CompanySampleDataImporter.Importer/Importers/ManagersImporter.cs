using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanySampleDataImporter.Data;

namespace CompanySampleDataImporter.Importer.Importers
{
    class ManagersImporter : IImporter
    {
        public Action<CompanyEntities, TextWriter> Get
        {
            get
            {

                return (db, tr) =>
                {
                    // tuk razdrobqwame ierarhiqta po porealistichen nachin. da ne  e samo shefowe i rabotnici
                    var levels = new[] { 5, 5, 10, 10, 10, 15, 15, 15, 15 };
                    List<int> previousManagers = null;


                    // tuk sortirame na random
                    var allEmployeeIds = db.Employees
                    .OrderBy(e => Guid.NewGuid()) // towa wryshta na ranodom. 
                    .Select(e => e.Id)
                    .ToList();

                    var currentPercentage = 0;
                    for (var i = 0; i < levels.Length; i++)
                    {
                        var level = levels[i];
                        var skip = (int)((currentPercentage * allEmployeeIds.Count) / 100.0);
                        var take = (int)((level * allEmployeeIds.Count) / 100.0);

                        var currentEmployeesId = // towa sa employee id-tata, koito iskame da update-nem, za tekushtiq level
                        allEmployeeIds          // tuk trqbwa da ima kajem koi ime e menidjry. za towa previousManagers
                        .Skip(skip)             // posle trqbwa da wzemem wsichki po ID ot bazata. za towa prwaim twa dolu var employees
                        .Take(take)
                        .ToList();

                        var employees =
                        db.Employees
                        .Where(e => currentEmployeesId.Contains(e.Id))
                        .ToList();


                        // sled towa ot wsichki employee, koito wzehme ot bazata, trqbwa da im updatnem managerId
                        foreach (var emp in employees)
                        {
                            emp.ManagerId =
                            previousManagers == null ? null : (int?)previousManagers[RandomGenerator.GetRandomNumber(0, previousManagers.Count - 1)];
                        }


                        tr.Write(".");



                        db.SaveChanges();
                        db.Dispose();
                        db = new CompanyEntities();


                        // sled towa trqbwa da updatnem previousManager, za da bydat tekushtite. 
                        previousManagers = currentEmployeesId;
                        currentPercentage += level;


                    }

                };
            }
        }

        public string Message
        {
            get
            {
                return "Importing Managers";
            }
        }

        public int Order
        {
            get
            {
                return 3;
            }
        }
    }
}
