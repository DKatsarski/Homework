namespace Events.UI
{
    using Logic;
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            CommandProcessor.ExecuteNextCommand();
            Console.WriteLine(Messages.ShowOutput());
        }
    }
}