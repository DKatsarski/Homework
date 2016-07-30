using System.Collections;
using System.Collections.Generic;

namespace UnitTesting.Contracts
{
    public interface ICourse : INameable
    {
        ICollection<IStudent> Students { get; }

        bool AddStudentToCourse(IStudent student);

        bool RemoveStudentFromCourse(IStudent student);
    }
}