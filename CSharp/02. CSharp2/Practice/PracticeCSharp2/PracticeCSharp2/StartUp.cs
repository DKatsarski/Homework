using Bazik;
using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public class PracticeCSharp2
    {
        static void Main()
        {

            Console.WriteLine(Reverse(-123));

        }


        public static int Reverse(int x)
        {

            string result = string.Empty;

            if (x > 0)
            {
                string lenghtOfNumber = x.ToString();
                long brecauseWTF = 0;

                for (int i = 0; i < lenghtOfNumber.Length; i++)
                {
                    result += (x % 10).ToString();
                    x = x / 10;
                }

                brecauseWTF = long.Parse(result);
                if (brecauseWTF > 2147483647 || brecauseWTF < -2147483648)
                {
                    return 0;

                }
            }
            else if (x < 0)
            {
                long omgThisThing = x;
                long inAnyCaseOfTooLongWTF = omgThisThing * -1;
                string lenghtOfNumber = inAnyCaseOfTooLongWTF.ToString();
                long brecauseWTF = 0;

                result += "-";

                for (int i = 0; i < lenghtOfNumber.Length; i++)
                {
                    result += (inAnyCaseOfTooLongWTF % 10).ToString();
                    inAnyCaseOfTooLongWTF = inAnyCaseOfTooLongWTF / 10;
                }

                brecauseWTF = long.Parse(result);

                if (brecauseWTF > 2147483647 || brecauseWTF < -2147483648)
                {
                    return 0;

                }
            }
            else
            {
                result = 0.ToString();
            }

            return int.Parse(result);
        }


    }

}
