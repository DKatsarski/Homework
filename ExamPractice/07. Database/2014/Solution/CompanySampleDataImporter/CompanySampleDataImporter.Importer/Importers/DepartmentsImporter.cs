using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

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
                        db.Departments.Add(new Departments()); // tuk na klipcheto ne e w mn chislo.55.27
                    }
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
