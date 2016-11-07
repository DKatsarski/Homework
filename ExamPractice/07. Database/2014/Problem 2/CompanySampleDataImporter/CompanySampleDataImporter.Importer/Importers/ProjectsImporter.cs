using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanySampleDataImporter.Data;

namespace CompanySampleDataImporter.Importer.Importers
{
    public class ProjectsImporter : IImporter
    {
        private const int NumberOfProjects = 100; // 10000

        public Action<CompanyEntities, TextWriter> Get
        {

            get
            {
                return (db, tr) =>
                {
                    var allEmployeesIds =
                    db.Employees
                    .OrderBy(e => Guid.NewGuid())
                    .Select(e => e.Id)
                    .ToList();

                    // trqbvwa da naprwaim na wseki proekt da s epadat sredno po 5 empl. za twoa si prwaim NumberOfProjects i dobawqme mevdu 2 i 8 proekta.

                    var currentEmplyeeIndex = 0; 
                    for (int i = 0; i < NumberOfProjects; i++)
                    {

                        var currentProject = new Project
                        {
                            Name = RandomGenerator.GetRandomString(5, 50),
                        };

                        var numberOfEmployeesPerProject = RandomGenerator.GetRandomNumber(2, 8);

                        for (int j = 0; j < numberOfEmployeesPerProject; j++)
                        {
                            if (j + currentEmplyeeIndex >= allEmployeesIds.Count) // towa e, za da ne gyrmi
                            {
                                break;
                            }

                            var currentEmployeeId = allEmployeesIds[currentEmplyeeIndex];

                            var startDate = RandomGenerator.GetRandomDate(before: DateTime.Now.AddDays(-100));
                            currentProject.ProjectsEmployees.Add(new ProjectsEmployee
                            {
                                EmployeeId = currentEmployeeId,
                                StartDate = startDate,
                                EndDate = RandomGenerator.GetRandomDate(after: startDate),
                            });

                            currentEmplyeeIndex++;
                        }

                        db.Projects.Add(currentProject);

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
                return "Importing Projects";
            }
        }

        public int Order
        {
            get
            {
                return 4;
            }
        }
    }
}
