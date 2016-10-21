using System;
using System.Collections;
using HWJSON.Contracts;

namespace HWJSON.Printers
{
    public class JsonPrinter : IPrinter
    {
        public void Print(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
