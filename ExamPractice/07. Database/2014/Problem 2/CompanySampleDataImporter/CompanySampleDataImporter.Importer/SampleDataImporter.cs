using CompanySampleDataImporter.Data;
using CompanySampleDataImporter.Importer.Importers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CompanySampleDataImporter.Importer
{
    public class SampleDataImporter
    {
        private TextWriter textWriter;

        private SampleDataImporter(TextWriter textWriter)
        {
            this.textWriter = textWriter;
        }

        public static SampleDataImporter Create(TextWriter textWriter)
        {
            return new SampleDataImporter(textWriter);
        }

        public void Import()
        {
            Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(IImporter).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .Select(t => (IImporter)Activator.CreateInstance(t))
            .OfType<IImporter>()
            .OrderBy(i => i.Order)
            .ToList()
            .ForEach(i =>
            {
                textWriter.Write(i.Message);

                var db = new CompanyEntities();
                i.Get(db, this.textWriter); // towa ni izwikwa towa, koeto napisahme klasowete (DepartmentsImporter primerno; Realno i-to predstawlqwa wseki otdelen klas.
                textWriter.WriteLine();
                });
        }
    }
}
