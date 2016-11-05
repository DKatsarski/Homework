using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHW
{
    public partial class NorthwindEntities : DbContext
    {
        public NorthwindEntities(string connectionString)
          : base($"name={connectionString}")
        {
        }
    }
}
