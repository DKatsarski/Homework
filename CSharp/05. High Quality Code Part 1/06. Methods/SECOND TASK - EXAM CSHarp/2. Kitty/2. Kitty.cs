using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Kitty
{
    class Program
    {
        public static void CheckIfThereIsNoFood(string soulsFoodDeadlocks)
        {
            if (soulsFoodDeadlocks[0].ToString() == "x")
            {
                Console.WriteLine("You are deadlocked, you greedy kitty!");
                Console.WriteLine("Jumps before deadlock: 0");
            }
        }

        static void Main(string[] args)
        {
            //input
            string soulsFoodDeadlocks = Console.ReadLine().Trim(' ');
            int[] kittyPath = Console.ReadLine().Trim(' ').Split(' ').Select(int.Parse).ToArray();


            //trqbwa mi kauntyr za souls, hrana i deadlock - t.e. 3 counter-a 
            int counterSouls = 0;
            int counterFood = 0;
            int counterDeadlocks = 0;
            int jumps = 0;
            int pathIndex = 0;


            //ako nqma hrana ili dushi kogato sreshten deadlock - krai  
            if (soulsFoodDeadlocks[pathIndex].ToString() == "x")
            {
                Console.WriteLine("You are deadlocked, you greedy kitty!");
                Console.WriteLine("Jumps before deadlock: 0");


            }
            else
            {
                for (int i = 0; i < kittyPath.Length; i++)
                {

                    //sibyram hrana ili deadlocks 
                    if (soulsFoodDeadlocks[pathIndex].ToString() == "@")
                    {
                        soulsFoodDeadlocks = soulsFoodDeadlocks.Remove(pathIndex, 1);
                        soulsFoodDeadlocks = soulsFoodDeadlocks.Insert(pathIndex, "M");
                        counterSouls++;
                        jumps++;
                    }
                    else if (soulsFoodDeadlocks[pathIndex].ToString() == "*")
                    {
                        soulsFoodDeadlocks = soulsFoodDeadlocks.Remove(pathIndex, 1);
                        soulsFoodDeadlocks = soulsFoodDeadlocks.Insert(pathIndex, "M");
                        counterFood++;
                        jumps++;
                    }
                    else if (soulsFoodDeadlocks[pathIndex].ToString() == "x")
                    {
                        //TODO: prowerka ako nqma hrana da umira i dapishe cifrite 
                        if (counterSouls == 0 || counterFood == 0)
                        {
                            //krai

                            break;
                        }
                        else if (pathIndex % 2 == 0)
                        {
                            soulsFoodDeadlocks = soulsFoodDeadlocks.Remove(pathIndex, 1);
                            soulsFoodDeadlocks = soulsFoodDeadlocks.Insert(pathIndex, "M");
                            counterDeadlocks++;
                            jumps++;
                            counterSouls--;
                        }
                        else if (pathIndex % 2 != 0)
                        {
                            soulsFoodDeadlocks = soulsFoodDeadlocks.Remove(pathIndex, 1);
                            soulsFoodDeadlocks = soulsFoodDeadlocks.Insert(pathIndex, "*");
                            counterFood--;
                            counterDeadlocks++;
                            jumps++;
                        }

                    }



                    //TUK DWIJA KOTKATA  
                    if (kittyPath[i] >= 0)
                    {
                        pathIndex = (kittyPath[i] + pathIndex) % soulsFoodDeadlocks.Length;
                    }
                    else if (kittyPath[i] < 0)
                    {
                        pathIndex = (pathIndex - (kittyPath[i] * (-1))) % soulsFoodDeadlocks.Length;
                        if (pathIndex < 0)
                        {
                            pathIndex += soulsFoodDeadlocks.Length;
                        }
                    }

                    if (i == kittyPath.Length - 1)
                    {

                        if (soulsFoodDeadlocks[pathIndex].ToString() == "@")
                        {
                            soulsFoodDeadlocks = soulsFoodDeadlocks.Remove(pathIndex, 1);
                            soulsFoodDeadlocks = soulsFoodDeadlocks.Insert(pathIndex, "M");
                            counterSouls++;
                            jumps++;
                        }
                        else if (soulsFoodDeadlocks[pathIndex].ToString() == "*")
                        {
                            soulsFoodDeadlocks = soulsFoodDeadlocks.Remove(pathIndex, 1);
                            soulsFoodDeadlocks = soulsFoodDeadlocks.Insert(pathIndex, "M");
                            counterFood++;
                            jumps++;
                        }
                        else if (soulsFoodDeadlocks[pathIndex].ToString() == "x")
                        {
                            //TODO: prowerka ako nqma hrana da umira i dapishe cifrite 
                            if (counterSouls == 0 || counterFood == 0)
                            {
                                //krai

                                break;
                            }
                            else if (pathIndex % 2 == 0)
                            {
                                soulsFoodDeadlocks = soulsFoodDeadlocks.Remove(pathIndex, 1);
                                soulsFoodDeadlocks = soulsFoodDeadlocks.Insert(pathIndex, "M");
                                counterDeadlocks++;
                                jumps++;
                                counterSouls--;
                            }
                            else if (pathIndex % 2 != 0)
                            {
                                soulsFoodDeadlocks = soulsFoodDeadlocks.Remove(pathIndex, 1);
                                soulsFoodDeadlocks = soulsFoodDeadlocks.Insert(pathIndex, "*");
                                counterFood--;
                                counterDeadlocks++;
                                jumps++;
                            }
                        }
                    }
                }

                if (counterSouls == 0 || counterFood == 0 && soulsFoodDeadlocks[pathIndex].ToString() == "x")
                {
                    Console.WriteLine("You are deadlocked, you greedy kitty!");
                    Console.WriteLine("Jumps before deadlock: {0}", jumps);
                }
                else
                {
                    Console.WriteLine("Coder souls collected: {0}", counterSouls);
                    Console.WriteLine("Food collected: {0}", counterFood);
                    Console.WriteLine("Deadlocks: {0}", counterDeadlocks);
                }
            }
        }
    }
}
