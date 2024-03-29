﻿using System;
using System.Diagnostics;

class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        // Preconditions here. They are implemented by using Assert
        // (although it should be done with Exceptions)due to the specifics of the task in the HW.
        Debug.Assert(arr != null, "arr can't be null!");
        // the following line is commented, so the the app could run, but could be used if a different logic is needed
        // Debug.Assert(arr.Length > 1, "arr should contain at least 2 elements in order to be sorted!");
        
        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);

            var testSwapingFirstNumber = arr[index];
            var testSwapingSecondNumber = arr[minElementIndex];

            Swap(ref arr[index], ref arr[minElementIndex]);

            // Test Swap method
            Debug.Assert(testSwapingFirstNumber.Equals( arr[minElementIndex]), "Swat method doesn's work!");
            Debug.Assert(testSwapingSecondNumber.Equals(arr[index]), "Swat method doesn's work!");
        }
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(startIndex >= 0 && startIndex < arr.Length - 1, "startIndex cannot be lower than 0 or bigger then arr.length");
        Debug.Assert(startIndex <= endIndex, "startIndex cannot be bigger than endIndex");
        Debug.Assert(endIndex >= startIndex, "endInex cannot be lower then startIndex");
        Debug.Assert(endIndex <= arr.Length - 1, "endInex cannot be bigger then arr lenght");


        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }
        
        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        Debug.Assert(x.GetType() == typeof(T));
        Debug.Assert(y.GetType() == typeof(T));

        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(value.GetType() == typeof(T));
        Debug.Assert(arr != null, "arr can't be null!");
        Debug.Assert(arr.Length > 1, "arr should contain at least 2 elements in order to be sorted!");
        Debug.Assert(startIndex >= 0 && startIndex < arr.Length - 1, "startIndex cannot be lower than 0 or bigger then arr.length");
        Debug.Assert(startIndex <= endIndex, "startIndex cannot be bigger than endIndex");
        Debug.Assert(endIndex >= startIndex, "endInex cannot be lower then startIndex");
        Debug.Assert(endIndex <= arr.Length - 1, "endInex cannot be bigger then arr lenght");


        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        // sample arrays for testing the SelectionSort method
        var arrZero = new int[] { };
        var arrOne = new int[] { 1 };

        SelectionSort(arrZero); // Test sorting empty array
        SelectionSort(arrOne); // Test sorting single element array

        Debug.Assert(arrZero.Length == 0, "SelectionSort didn't work");
        Debug.Assert(arrOne.Length == 1, "SelectionSort didn't work");

        // test binarySearch
        var testArrayLimits = TestArrayLimitsMinNum(arr);
        var numberOutSideBounderisOfArr = testArrayLimits - 200;
        var testBinarySearch = (BinarySearch(arr, numberOutSideBounderisOfArr));
        Debug.Assert(testBinarySearch == -1, "No such number in array!");

        var testArrayLimitsOverMaxNum = TestArrayLimitsMaxNum(arr);
        var numberOverArrayBounderies = testArrayLimitsOverMaxNum + 223;
        testBinarySearch = (BinarySearch(arr, numberOverArrayBounderies));
        Debug.Assert(testBinarySearch == -1, "No such number in array!");


        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }

    public static int TestArrayLimitsMinNum(int[] arr)
    {
        var minElementIndex = int.MinValue;
        for (int i = 0 + 1; i < arr.Length; i++)
        {
            if (minElementIndex > arr[i])
            {
                minElementIndex = arr[i];
            }
        }

        return minElementIndex;
    }

    public static int TestArrayLimitsMaxNum(int[] arr)
    {
        var maxElementIndex = arr[0];
        for (int i = 0 + 1; i < arr.Length; i++)
        {
            if (maxElementIndex < arr[i])
            {
                maxElementIndex = arr[i];
            }
        }

        return maxElementIndex;
    }
}
