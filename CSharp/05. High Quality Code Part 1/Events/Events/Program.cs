namespace Events
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            CommandProcessor.ExecuteNextCommand();
            Console.WriteLine(Messages.ShowOutput());
        }
    }
}