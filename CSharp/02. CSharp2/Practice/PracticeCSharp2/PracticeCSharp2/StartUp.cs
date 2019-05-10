namespace PracticeCSharp2
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class StartUp
    {

        static void Main()
        {
            IWriter consoleWrtier = new ConsoleWriter();
            IWriter fileWriter = new FileWriter();

            MyWrtier(consoleWrtier);
            MyWrtier(fileWriter);
        }

        public static void MyWrtier(IWriter wrtier)
        {
            wrtier.Write("Exmaple Of Interface");
        }






    }
}
