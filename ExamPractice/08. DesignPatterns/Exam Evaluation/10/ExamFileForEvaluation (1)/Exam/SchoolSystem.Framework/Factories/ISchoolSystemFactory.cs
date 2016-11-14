using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Framework.Factories
{
    public interface ISchoolSystemFactory
    {
        ITeacher CreateTeacher(string firstName, string lastName, Subject subject);
        IStudent CreateStudent(string firstName, string lastName, Grade grade);
        IMark CreateMark(Subject subject, float value);
        ICommand GetCreateStudentCommand(TypeInfo commandType);
        ICommand GetCreateTeacherCommand(TypeInfo commandType);
        ICommand GetRemoveStudentCommand(TypeInfo commandType);
        ICommand GetRemoveTeacherCommand(TypeInfo commandType);
        ICommand GetStudentListMarksCommand(TypeInfo commandType);
        ICommand GetTeacherAddMarkCommand(TypeInfo commandType);
    }
}
