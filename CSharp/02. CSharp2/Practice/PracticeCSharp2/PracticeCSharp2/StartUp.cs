namespace PracticeCSharp2
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            decimal asdf = 2344.234234m;
            int a = 2;

            Console.WriteLine(asdf.ToPrice());

            Console.WriteLine(a.AlittleMoreInt());

        }

        public static void MyWrtier(IWriter wrtier)
        {
            wrtier.Write("Exmaple Of Interface");
        }
    }
}
