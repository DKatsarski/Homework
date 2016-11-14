using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Core.Contracts;
using SchoolSystem.Framework.Core.Commands;

namespace SchoolSystem.Framework.Core.Providers
{
    public class CommandParserProvider : IParser
    {
        public ICommand ParseCommand(string fullCommand)
        {
            var commandName = fullCommand.Split(' ')[0];
            var commandTypeInfo = this.FindCommand(commandName);
            ICommand command = null;
            if (commandName == "CreateStudent")
            {
                command = Engine.Factory.GetCreateStudentCommand(commandTypeInfo);
            }
            else if (commandName == "CreateTeacher")
            {
                command = Engine.Factory.GetCreateTeacherCommand(commandTypeInfo);
            }
            else if (commandName == "RemoveStudent")
            {
                command = Engine.Factory.GetRemoveStudentCommand(commandTypeInfo);
            }
            else if (commandName == "RemoveTeacher")
            {
                command = Engine.Factory.GetRemoveTeacherCommand(commandTypeInfo);
            }
            else if (commandName == "StudentListMarks")
            {
                command = Engine.Factory.GetStudentListMarksCommand(commandTypeInfo);
            }
            else if (commandName == "TeacherAddMark")
            {
                command = Engine.Factory.GetTeacherAddMarkCommand(commandTypeInfo);
            }

            //var command = Engine.Factory.CreateCommand(commandTypeInfo);
            //Activator.CreateInstance(commandTypeInfo) as ICommand;

            return command;
        }

        public IList<string> ParseParameters(string fullCommand)
        {
            var commandParts = fullCommand.Split(' ').ToList();
            commandParts.RemoveAt(0);

            if (commandParts.Count() == 0)
            {
                return null;
            }

            return commandParts;
        }

        private TypeInfo FindCommand(string commandName)
        {
            var currentAssembly = this.GetType().GetTypeInfo().Assembly;
            var commandTypeInfo = currentAssembly.DefinedTypes
                .Where(type => type.ImplementedInterfaces.Any(inter => inter == typeof(ICommand)))
                .Where(type => type.Name.ToLower().Contains(commandName.ToLower()))
                .SingleOrDefault();

            if (commandTypeInfo == null)
            {
                throw new ArgumentException("The passed command is not found!");
            }

            return commandTypeInfo;
        }
    }
}
