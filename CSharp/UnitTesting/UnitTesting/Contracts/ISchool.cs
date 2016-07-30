using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Contracts
{
    public interface  ISchool : INameable
    {
        ICollection<IStudent> Students { get; }

        ICollection<ICourse> Courses { get; }

        bool AdmitStudent(IStudent student);
    }
}
