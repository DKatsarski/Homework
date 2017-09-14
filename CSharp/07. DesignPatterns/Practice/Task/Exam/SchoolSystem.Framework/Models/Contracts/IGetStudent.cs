using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Framework.Models.Contracts
{
    public interface IGetStudent
    {
        IStudent GetStudent(int studentId);
    }
}
