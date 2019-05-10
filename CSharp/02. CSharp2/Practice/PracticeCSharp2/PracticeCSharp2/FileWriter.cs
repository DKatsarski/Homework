using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public class FileWriter : IWriter
    {
        public void Write(string message)
        {
            string[] array = new string[] { message };
            System.IO.File.WriteAllLines(@"C:\Users\dkats\Desktop\Programming\Homework\CSharp\02. CSharp2\Practice\PracticeCSharp2\PracticeCSharp2\bin\Debug\asdf.txt", array);
        }
    }
}
