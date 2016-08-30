namespace Events.UI
{
    using System;

    using Logic;

    public class Program
    {
        public static void Main(string[] args)
        {
            CommandProcessor.ExecuteNextCommand();
            Console.WriteLine(Messages.ShowOutput());
        }
    }
}