using Bazik.Contracts;
using System;

namespace Bazik
{
    public class Writer : IWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
