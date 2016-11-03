using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHW
{
    public class Startup
    {
        static void Main()
        {
            using (var db = new NorthwindEntities())
            {
                var project = db.Regions
                    .ToList();
                Console.WriteLine(project.Count);
            }
        }
    }
}
