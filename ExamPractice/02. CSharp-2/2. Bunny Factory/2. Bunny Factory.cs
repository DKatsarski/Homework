using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bunny_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int index = 0;
            list.Add(Console.ReadLine());
            // input here 
            while (list.ElementAt(index) != "END")
            {
                index++;
                list.Add(Console.ReadLine());
            }



            //taking the first elemnt

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                if (list.Count <= i)
                {
                    break;
                }

                int current = int.Parse(list.ElementAt(i));
                for (int j = 0; j < i; j++)
                {
                    current += int.Parse(list.ElementAt(j));
                }
                if (current > list.Count - i)
                {
                    break;
                }

                BigInteger sum = BigInteger.Parse(list.ElementAt(i + 1));
                BigInteger product = BigInteger.Parse(list.ElementAt(i + 1));

                for (int m = i + 1; m < current + i; m++)
                {
                    sum += BigInteger.Parse(list.ElementAt(m + 1));
                    product *= BigInteger.Parse(list.ElementAt(m + 1));
                }
                // do tuk dobre
                string firstSum = sum.ToString();
                string secondProduct = product.ToString();

                list.RemoveRange(0, i + current + 1);
                list.Insert(0, firstSum);
                list.Insert(1, secondProduct);

                //tuk imam problem 
                sb.Clear();
                for (int z = 0; z < list.Count; z++)
                {
                    sb.Append(list.ElementAt(z));
                }

                sb.Replace("1", "");
                sb.Replace("0", "");
                sb.Replace("END", "");
                list.Clear();

                for (int d = 0; d < sb.Length; d++)
                {
                    list.Add(sb[d].ToString());
                }

            }
            for (int i = 0; i < sb.Length; i++)
            
{
                if (i == sb.Length - 1)
                {
                    Console.Write("{0}", sb[i]);
                }
                else
                {
                    Console.Write("{0} ", sb[i]);
                }
              
            }

         
        }
    }
}
