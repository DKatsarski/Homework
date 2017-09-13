using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Framework.Models.Contracts
{
    public interface IAddStudent
    {
        void AddStudent(int studentId, IStudent student);
    }
}
