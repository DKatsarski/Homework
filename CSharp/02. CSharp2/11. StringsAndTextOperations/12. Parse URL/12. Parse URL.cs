using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Parse_URL
{
    class Program
    {
        static void Main(string[] args)
        {
            string adress = Console.ReadLine();
            int indexOfdosts = adress.IndexOf("://");
            int indexOfSlash = adress.IndexOf("/", indexOfdosts + 3);
            StringBuilder sb = new StringBuilder();

            PrintProtocol(adress, indexOfdosts, sb);
            PrintServer(adress, indexOfdosts, indexOfSlash, sb);

            PrintResorce(adress, indexOfSlash, sb);
        }

        private static void PrintResorce(string adress, int indexOfSlash, StringBuilder sb)
        {
            //resource
            for (int i = indexOfSlash; i < adress.Length; i++)
            {
                sb.Append(adress[i]);
            }
            Console.WriteLine("[resource] = {0}", sb);
        }

        private static void PrintServer(string adress, int indexOfdosts, int indexOfSlash, StringBuilder sb)
        {

            //server
            for (int i = indexOfdosts + 3; i < adress.Length; i++)
            {
                if (i == indexOfSlash)
                {
                    break;
                }
                sb.Append(adress[i]);

            }
            Console.WriteLine("[server] = {0}", sb);
            sb.Clear();
        }

        public static void PrintProtocol(string adress, int indexOfdosts, StringBuilder sb)
        {
            //protocol
            for (int i = 0; i < adress.Length; i++)
            {
                if (i == indexOfdosts)
                {
                    break;
                }
                sb.Append(adress[i]);
            }
            Console.WriteLine("[protocol] = {0}", sb);
            sb.Clear();
        }
    }
}
