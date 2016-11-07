using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanySampleDataImporter.Data;

namespace CompanySampleDataImporter.Importer.Importers
{
    public class ReportsImporter : IImporter
    {
        public Action<CompanyEntities, TextWriter> Get
        {
            get
            {
                return (db, tr) =>
                {
                    // towa, che imam sredno po 50 empl. na report, oznachawa che dyprwame wsichki empl i im zakachame po sredno 50 reports i towa e

                    var employeeIds = db // wzimame si wsichki employees
                    .Employees
                    .Select(e => e.Id)
                    .ToList();

                    for (int i = 0; i < employeeIds.Count; i++)
                    {
                        var numberOfReports = RandomGenerator.GetRandomNumber(25, 75); // sredno 50

                        for (int j = 0; j < numberOfReports; j++)
                        {
                            //syzdawame now report
                            var report = new Report
                            {
                                EmployeeId = employeeIds[i],
                                Time = RandomGenerator.GetRandomDate(before: DateTime.Now)
                            };

                            db.Reports.Add(report);
                        }

                        tr.Write(".");

                        db.SaveChanges();
                        db.Dispose();
                        db = new CompanyEntities();
                    }
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
                return 5;
            }
        }
    }
}
