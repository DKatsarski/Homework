using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Contracts
{
    public interface ICourse
    {
        ICollection<IStudent> Students { get; set; }

        void AddStudent(Student student);
        void RemoveStudent(Student student);
    }
}
