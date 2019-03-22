using System.Collections.Generic;

namespace School
{
    public interface IListOfTeachers
    {
        IEnumerable<string> Teachers { get; }

        void AddTeacher(string name);
        void SayAngryWords(string words);
    }
}