using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanySampleDataImporter.Data;

namespace CompanySampleDataImporter.Importer.Importers
{
    public class EmpolyeesImporter : IImporter
    {
        private const int NumberOfEmployees = 500; // should be 5000

        public Action<CompanyEntities, TextWriter> Get
        {
            get
            {
                return (db, tr) =>
                {
                    var departmentsIds = db
                    .Departments
                    .Select(d => d.Id)
                    .ToList();

                    for (int i = 0; i < NumberOfEmployees; i++)
                    {
                        var randomDepartmentIndex = RandomGenerator.GetRandomNumber(0, departmentsIds.Count - 1);

                        var randomDepartmentId = departmentsIds[randomDepartmentIndex];

                        db.Employees.Add(new Employee
                        {
                            FirstName = RandomGenerator.GetRandomString(5, 20),
                            LastName = RandomGenerator.GetRandomString(5, 20),
                            YearSalary = RandomGenerator.GetRandomNumber(50000, 200000),
                            DepartmentId = randomDepartmentId
                        });

                        if (i % 10 == 0)
                        {
                            tr.Write(".");
                        }

                        if (i % 100 == 0)
                        {
                            db.SaveChanges();
                            db.Dispose();
                            db = new CompanyEntities();
                        }
                    }
                    db.SaveChanges();
                };
            }
        }

        public string Message
        {
            get
            {
                return "Importing Empolyees";
            }
        }

        public int Order
        {
            get
            {
                return 2;
            }
        }
    }
}
