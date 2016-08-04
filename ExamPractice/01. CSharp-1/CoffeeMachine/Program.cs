using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double nOne = double.Parse(Console.ReadLine()) * 0.05;
            double nTwo = double.Parse(Console.ReadLine()) * 0.10; ;
            double nThree = double.Parse(Console.ReadLine()) * 0.20; ;
            double nFour = double.Parse(Console.ReadLine()) * 0.50; ;
            double nFive = double.Parse(Console.ReadLine()) * 1.00; ;
            double amountOfMoney = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double machineMoneyTotal = nOne + nTwo + nThree + nFour + nFive;

            if (price > amountOfMoney)
            {
                Console.WriteLine("More {0:F2}", price - amountOfMoney);
            }
            else if (amountOfMoney > price + machineMoneyTotal)
            {
                {
                    Console.WriteLine("No {0:F2}", amountOfMoney - price - machineMoneyTotal);
                }
            }
            else
            {
              
                
                  Console.WriteLine("Yes {0:F2}", machineMoneyTotal - (amountOfMoney - price));
                
            }
        }
    }
}
