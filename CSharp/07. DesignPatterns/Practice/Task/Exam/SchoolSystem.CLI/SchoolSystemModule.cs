﻿using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
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

            Kernel.Bind<IReader>().To<ConsoleReaderProvider>();
            Kernel.Bind<IWriter>().To<ConsoleWriterProvider>();
            Kernel.Bind<IParser>().To<CommandParserProvider>();
            Kernel.Bind<IStudent>().To<Student>();

            Kernel.Bind<Engine>().ToSelf();


            Kernel.Bind<CreateStudentCommand>().ToSelf().InSingletonScope();

            Kernel.Bind<CreateTeacherCommand>().ToSelf().InSingletonScope();


            Kernel.Bind<ICommandFactory>().ToFactory();

            Kernel.Bind<ICommand>().ToMethod(context =>
            {
                IParameter typeParameters = context.Parameters.Single();
                Type type = (Type)typeParameters.GetValue(context, null);

                return (ICommand)context.Kernel.Get(type);
            }).NamedLikeFactoryMethod((ICommandFactory commandFactory) => commandFactory.GetCommand(null)) ;


            IConfigurationProvider configurationProvider = Kernel.Get<IConfigurationProvider>();
            if (configurationProvider.IsTestEnvironment)
            {
            }
        }
    }
}