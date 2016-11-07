using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace CompanySampleDataImporter.Importer.Importers
{
    public class EmpolyeesImporter : IImporter
    {
        public Action<CompanyEntities, TextWriter> Get
        {
            get
            {
                throw new NotImplementedException();
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
