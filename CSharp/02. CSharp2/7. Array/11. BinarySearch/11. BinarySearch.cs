using System;

public class BinarySearch
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int[] arr = new int[a];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine(Array.IndexOf(arr, x));
    }
}