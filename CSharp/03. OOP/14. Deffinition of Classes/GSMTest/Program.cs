using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
        public class GSMTest
    {
        private GSM[] phones = { new GSM("iPhone 2s", "Apple", 30, "Dragan", new Battery(), new Display(2.5, 250000)),
             new GSM("Iliantsi", "Unknown", 3, "Pesho", new Battery(), new Display(2.5, 250000)),
              new GSM("Nokia m5", "Nokia", 700, "Stanka", new Battery(), new Display(7.5, 250000)) };

        public void DisplayGSM()
        {
            foreach (var gsm  in phones)
            {
                gsm.DisplayInfo();
            }

            GSM.IPhone4S.DisplayInfo();
        }

      

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
