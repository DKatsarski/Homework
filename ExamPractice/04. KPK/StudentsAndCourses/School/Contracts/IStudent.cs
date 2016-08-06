using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Contracts
{
    public interface IStudent
    {
        string Name { get; set; }
        int Number { get; set; }
        void JoinCourse(ICourse course);
        void LeaveCourse(ICourse course);

    }
}
