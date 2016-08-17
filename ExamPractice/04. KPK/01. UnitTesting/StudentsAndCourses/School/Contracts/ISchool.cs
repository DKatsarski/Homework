using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Contracts
{
    public interface ISchool
    {
        ICollection<ICourse> Courses { get; }
        ICollection<IStudent> Students { get; }
    }
}
