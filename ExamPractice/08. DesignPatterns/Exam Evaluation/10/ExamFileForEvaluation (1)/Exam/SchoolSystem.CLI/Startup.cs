using Ninject;
using SchoolSystem.Framework.Core;
using System.Reflection;

namespace SchoolSystem.Cli
{
    public class Startup
    {
        public static void Main()
        {

            var ninject = new StandardKernel();
            ninject.Load(Assembly.GetExecutingAssembly());

            var engine = ninject.Get<IEngine>();
            engine.Start();

        }
    }
}