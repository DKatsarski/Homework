namespace HWFirstTask
{
    using System;

    public static class StringWriter
    {
        public static void PrintString(bool isTrue)
        {
            string stringToBePrinted = isTrue.ToString();
            Console.WriteLine(stringToBePrinted);
        }
    }
}
