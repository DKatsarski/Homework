using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
using Ninject.Modules;
using SchoolSystem.Framework.Factories;
using SchoolSystem.Framework.Core;
using SchoolSystem.Framework.Core.Contracts;
using SchoolSystem.Framework.Core.Providers;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Core.Commands;

namespace SchoolSystem.Cli.NinjectBindings
{
    public class SchoolSystemBindings : NinjectModule
    {
        private const string CreateStudentCommandName = "CreateStudentCommand";
        private const string CreateTeacherCommandName = "CreateTeacherCommand";
        private const string RemoveStudentCommandName = "RemoveStudentCommand";
        private const string RemoveTeacherCommandName = "RemoveTeacherCommand";
        private const string StudentListMarksCommandName = "StudentListMarksCommand";
        private const string TeacherAddMarkCommandName = "TeacherAddMarkCommand";
        public override void Load()
        {
            Kernel.Bind(x =>
                x.FromThisAssembly()
                .SelectAllClasses()
                .BindDefaultInterface()
            );

            this.Bind<IParser>().To<CommandParserProvider>();
            this.Bind<IReader>().To<ConsoleReaderProvider>();
            this.Bind<IWriter>().To<ConsoleWriterProvider>();
            this.Bind<ISchoolSystemFactory>().ToFactory().InSingletonScope();

            this.Bind<ICommand>().To<CreateStudentCommand>().Named(CreateStudentCommandName);
            this.Bind<ICommand>().To<CreateTeacherCommand>().Named(CreateTeacherCommandName);
            this.Bind<ICommand>().To<RemoveStudentCommand>().Named(RemoveStudentCommandName);
            this.Bind<ICommand>().To<RemoveTeacherCommand>().Named(RemoveTeacherCommandName);
            this.Bind<ICommand>().To<StudentListMarksCommand>().Named(StudentListMarksCommandName);
            this.Bind<ICommand>().To<TeacherAddMarkCommand>().Named(TeacherAddMarkCommandName);

        }
    }
}
