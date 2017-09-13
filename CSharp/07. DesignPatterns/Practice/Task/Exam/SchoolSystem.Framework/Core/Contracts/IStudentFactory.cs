using SchoolSystem.Framework.Core.Commands;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Framework.Core.Contracts
{
    public interface IStudentFactory
    {
        IStudent CreateStudent(string firstName, string lastName, Grade grade);
    }
}
