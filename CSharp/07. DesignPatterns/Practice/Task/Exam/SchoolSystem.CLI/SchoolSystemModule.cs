using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Modules;
using SchoolSystem.Cli.Configuration;
using SchoolSystem.Framework.Core;
using SchoolSystem.Framework.Core.Contracts;
using SchoolSystem.Framework.Core.Providers;
using SchoolSystem.Framework.Models;
using SchoolSystem.Framework.Models.Contracts;
using System.IO;
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


            IConfigurationProvider configurationProvider = Kernel.Get<IConfigurationProvider>();
            if (configurationProvider.IsTestEnvironment)
            {
            }
        }
    }
}