using System;

namespace ControlFlowAndStuff.Task_2
{
    public class RefactorIfStatement
    {
        internal void Task2(Potato potato)
        {
            //should implement more code here. This method is not working completely well.
            if (potato == null)
            {
                throw new ArgumentNullException();
            }

            if (potato.IsPeeled || !potato.IsRotten)
            {
                Cook(potato);
            }
        }

        internal bool Cook(Potato potato)
        {
            bool isCoocked = false;

            while (!isCoocked)
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (potato.CookingTimeNeeded == i)
                    {
                        isCoocked = true;
                        break;
                    }
                }
            }

            return isCoocked;
        }
    }
}
