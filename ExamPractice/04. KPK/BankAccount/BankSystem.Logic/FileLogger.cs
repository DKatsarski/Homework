using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Logic
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText("logg.txt", $"[{DateTime.Now}] {message}{Environment.NewLine}");
        }
    }
}
