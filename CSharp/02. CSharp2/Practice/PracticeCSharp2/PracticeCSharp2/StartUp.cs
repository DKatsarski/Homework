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
            var arr = new int[] { 3 ,2 ,1 ,3 }; // Convert.ToInt32(Console.ReadLine());


             IsAnArrayTelescopic(arr);

            Console.WriteLine(IsAnArrayTelescopic(arr));
        }

        public static bool IsAnArrayTelescopic(int[] arrayToBeTested)
        {
            int number = 1;
            bool arrrayIsTelescopic = false;
            int lengthOfHalfArrayPluesOne = (arrayToBeTested.Length / 2);

            if (arrayToBeTested.Length % 2 == 0)
            {
                for (int i = 0; i < arrayToBeTested.Length / 2; i++)
                {
                    if (arrayToBeTested[i] == number)
                    {
                        arrrayIsTelescopic = true;
                        number++;
                    }
                    else
                    {
                        arrrayIsTelescopic = false;
                        break;
                    }
                }

                if (arrrayIsTelescopic == true)
                {
                    number = arrayToBeTested.Length / 2;

                    for (int i = arrayToBeTested.Length / 2; i < arrayToBeTested.Length; i++)
                    {
                        if (arrayToBeTested[i] == number)
                        {
                            arrrayIsTelescopic = true;
                            number--;
                        }
                        else
                        {
                            arrrayIsTelescopic = false;
                            break;
                        }
                    }
                }
                else
                {
                    return arrrayIsTelescopic;
                }

            }
            else
            {

                for (int i = 0; i < arrayToBeTested.Length / 2; i++)
                {

                    if (arrayToBeTested[i] == number)
                    {
                        arrrayIsTelescopic = true;
                        number++;
                    }
                    else
                    {
                        arrrayIsTelescopic = false;
                        break;
                    }
                }

                if (arrayToBeTested[lengthOfHalfArrayPluesOne] == number)
                {
                    arrrayIsTelescopic = true;
                    number++;
                }
                else
                {
                    arrrayIsTelescopic = false;
                }

                if (arrrayIsTelescopic == true)
                {
                    number = arrayToBeTested.Length / 2;

                    for (int i = (arrayToBeTested.Length / 2) + 1; i < arrayToBeTested.Length; i++)
                    {
                        if (arrayToBeTested[i] == number)
                        {
                            arrrayIsTelescopic = true;
                            number--;
                        }
                        else
                        {
                            arrrayIsTelescopic = false;
                            break;
                        }
                    }
                }
                else
                {
                    return arrrayIsTelescopic;
                }
            }
            return arrrayIsTelescopic;
        }
    }
}
