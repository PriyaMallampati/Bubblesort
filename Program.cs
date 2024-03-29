﻿/* Author: Priya Mallampati
   Date : 28/02/2024
   This is code for Bubble sort */

using System;

class BubbleSort
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 72, 3, 14, 7, 1 };
        Console.WriteLine("Array before sorting:");
        PrintArray(arr);

        BubbleSortArray(arr);

        Console.WriteLine("\nArray after sorting:");
        PrintArray(arr);
    }

    static void BubbleSortArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
