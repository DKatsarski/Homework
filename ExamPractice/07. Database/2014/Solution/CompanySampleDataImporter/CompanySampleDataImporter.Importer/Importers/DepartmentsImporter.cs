using CompanySampleDataImporter.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySampleDataImporter.Importer.Importers
{
    public class DepartmentsImporter : IImporter
    {
        private const int NumberOfDepartments = 10; // should be 100

        public Action<CompanyEntities, TextWriter> Get
        {
            get
            {
                return (db, tr) =>
                {
                    for (int i = 0; i < NumberOfDepartments; i++)
                    {
                        db.Departments.Add(new Department
                        {
                            Name = RandomGenerator.GetRandomString(10, 50), //данните вътре се е попълват спрямо условието 


                        }); // tuk na klipcheto ne e w mn chislo.55.27

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

                    db.SaveChanges(); // towa tuk go prawimm, zashoto ako e pod 100, nqma da se zpaishe
                };
            }
        }

        public string Message
        {
            get
            {
                return "Importing Departments";
            }
        }

        public int Order
        {
            get
            {
                return 1;
            }
        }
    }
}
