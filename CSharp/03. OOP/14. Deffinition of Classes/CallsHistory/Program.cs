using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{


    public class GsmCallHistoryTest
    {
        private GSM myGsm = new GSM("S2", "Samsung");
        private const decimal PricePerMinute = 0.25m;

        public void Functionality()
        {
            myGsm.AddCall(new Calls(new DateTime(2015, 03, 09, 12, 30, 05), "0887 48 45 66", 520));
            myGsm.AddCall(new Calls(new DateTime(2015, 03, 10, 13, 03, 55), "0887 33 45 69", 320));
            myGsm.AddCall(new Calls(new DateTime(2015, 03, 10, 14, 13, 05), "0887 48 22 64", 678));
            myGsm.AddCall(new Calls(new DateTime(2015, 03, 14, 22, 03, 25), "0887 48 45 66", 432));
            myGsm.AddCall(new Calls(new DateTime(2015, 03, 16, 22, 03, 05), "0887 48 45 66", 270));

            Console.WriteLine(myGsm.CallHistoryInfo());
            Console.WriteLine("Total price: {0:f2} BGN", myGsm.CalculateTotalCallPrice(PricePerMinute));

            Calls longestCall = myGsm.CallHistory.OrderByDescending(x => x.DurationInSeconds).First();

            myGsm.DeleteCall(longestCall);

            Console.WriteLine(
                "Total price after removing longest call is {0:f2} BGN",
                myGsm.CalculateTotalCallPrice(PricePerMinute));

            myGsm.ClearHistory();

            Console.WriteLine(myGsm.CallHistoryInfo());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
