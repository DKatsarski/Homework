namespace PracticeCSharp2
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class StartUp
    {

        static void Main()
        {

            bool a = false;
            bool b = true;
            Console.WriteLine(b || (a & !b));

        }

        public static void MyWrtier(IWriter wrtier)
        {
            wrtier.Write("Exmaple Of Interface");
        }






    }
}
