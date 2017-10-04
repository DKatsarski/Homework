using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
using Ninject.Extensions.Interception;
using Ninject.Extensions.Interception.Infrastructure.Language;



using Ninject.Modules;
using Ninject.Parameters;
using SchoolSystem.Cli.Configuration;
using SchoolSystem.Framework.Core;
using SchoolSystem.Framework.Core.Commands;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Core.Contracts;
using SchoolSystem.Framework.Core.Providers;
using SchoolSystem.Framework.Models;
using SchoolSystem.Framework.Models.Contracts;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;


namespace SchoolSystem.Cli
{
    public class SchoolSystemModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IConfigurationProvider>().To<ConfigurationProvider>();

            Kernel.Bind<IReader>().To<ConsoleReaderProvider>().InSingletonScope();
            Kernel.Bind<IWriter>().To<ConsoleWriterProvider>().InSingletonScope();
            Kernel.Bind<IParser>().To<CommandParserProvider>().InSingletonScope();

            Kernel.Bind<IStudent>().To<Student>();
            Kernel.Bind<ITeacher>().To<Teacher>();
            Kernel.Bind<IMark>().To<Mark>();



            Kernel.Bind<ITeacherFactory>().ToFactory().InSingletonScope();




            Bind(typeof(IAddStudent), typeof(IAddTeacher), typeof(IRemoveStudent), typeof(IRemoveTeacher), typeof(IGetStudent),
                typeof(IGetTeacher), typeof(IGetStudentAndTeacher))
                .To<School>().InSingletonScope(); //twa e bindinga za school-a 




            Kernel.Bind<Engine>().ToSelf();


            Kernel.Bind<CreateStudentCommand>().ToSelf().InSingletonScope();

            Kernel.Bind<CreateTeacherCommand>().ToSelf().InSingletonScope();

            Kernel.Bind<RemoveStudentCommand>().ToSelf().InSingletonScope();

            Kernel.Bind<RemoveTeacherCommand>().ToSelf().InSingletonScope();

            Kernel.Bind<StudentListMarksCommand>().ToSelf().InSingletonScope();

            Kernel.Bind<TeacherAddMarkCommand>().ToSelf().InSingletonScope();





            var studentFacotoryBinding = Kernel.Bind<IStudentFactory>().ToFactory().InSingletonScope();
            var commandFacotyrBinding = Kernel.Bind<ICommandFactory>().ToFactory();
            var markFactoryBinding = Kernel.Bind<IMarkFactory>().ToFactory().InSingletonScope();


            Kernel.Bind<ICommand>().ToMethod(context =>
            {
                IParameter typeParameters = context.Parameters.Single();
                Type type = (Type)typeParameters.GetValue(context, null);

                return (ICommand)context.Kernel.Get(type);
            }).NamedLikeFactoryMethod((ICommandFactory commandFactory) => commandFactory.GetCommand(null));


            IConfigurationProvider configurationProvider = Kernel.Get<IConfigurationProvider>();
            if (configurationProvider.IsTestEnvironment)
            {
                commandFacotyrBinding.Intercept().With<StopwatchInterceptor>();
                studentFacotoryBinding.Intercept().With<StopwatchInterceptor>();
                markFactoryBinding.Intercept().With<StopwatchInterceptor>();

            }


        }
    }

    public class StopwatchInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine($"Calling method {invocation.Request.Method.Name} GetCommand of type {invocation.Request.Method.DeclaringType.Name}...");

            stopwatch.Start();
            invocation.Proceed();
            stopwatch.Stop();

            Console.WriteLine($"Total execution time for method {invocation.Request.Method.Name} of type {invocation.Request.Method.DeclaringType.Name} is {stopwatch.Elapsed.Milliseconds}.");
        }
    }
}