using System;


namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            decimal result = 0;
            decimal currentBracketResult = 0;
            char currentOperator = '+';
            char currentBracketOperator = '+';


            bool inbracket = false;
            foreach (char symbol in expression)
            {
                if (symbol == '(')
                {
                    inbracket = true;
                    continue;
                }

                if (symbol == ')')
                {
                    inbracket = false;
                    switch (currentOperator)
                    {
                        case '+': result += currentBracketResult; break;
                        case '*': result *= currentBracketResult; break;
                        case '-': result -= currentBracketResult; break;
                        case '/': result /= currentBracketResult; break;
                    }
                    currentBracketResult = 0;
                    currentBracketOperator = '+';
                }

                if (symbol == '+' ||
                    symbol == '-' ||
                    symbol == '/' ||
                    symbol == '*' )
                {
                    if (inbracket)
                    {
                        currentBracketOperator = symbol;
                    }
                    else
                    {
                        currentOperator = symbol;
                    }
                }

                if (symbol >= '0' && symbol <= '9')
                {
                    int currentNumber = symbol - '0';

                    if (inbracket)
                    {
                        switch (currentBracketOperator)
                        {
                            case '+': currentBracketResult += currentNumber; break;
                            case '*': currentBracketResult *= currentNumber; break;
                            case '-': currentBracketResult -= currentNumber; break;
                            case '/': currentBracketResult /= currentNumber; break;

                        }
                    }
                    else
                    {
                        switch (currentOperator)
                        {
                            case '+': result += currentNumber; break;
                            case '*': result *= currentNumber; break;
                            case '-': result -= currentNumber; break;
                            case '/': result /= currentNumber; break;

                        }
                    }
                
                }
            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}
