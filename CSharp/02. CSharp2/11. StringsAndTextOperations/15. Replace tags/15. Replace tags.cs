using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Replace_tags
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(Console.ReadLine());
       
            string a = "]";
            string end = "\"" + ">";
            sb = sb.Replace("<a href=\"", "[URL=");
            sb = sb.Replace(end, a);
            sb = sb.Replace("</a>", "[/url]");

            Console.Write(sb);
            

        }
    }
}
