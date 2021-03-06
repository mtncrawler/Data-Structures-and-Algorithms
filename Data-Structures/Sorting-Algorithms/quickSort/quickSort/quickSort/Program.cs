﻿using System;

namespace quickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Quick Sort!");
            Console.WriteLine();

            Console.WriteLine("Your current array: ");
            int[] myArr = { 76, 7, 1, 65, 99 };

            Console.WriteLine(String.Join(", ", myArr));
            Console.WriteLine();

            Console.WriteLine("Your quick sorted array: ");
            int[] output = QuickSort(myArr, 0, myArr.Length-1);
            Console.WriteLine(String.Join(", ", output));
        }

        public static int[] QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);

                QuickSort(arr, left, position - 1);

                QuickSort(arr, position + 1, right);         
            }
            return arr;
        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }

            Swap(arr, right, low + 1);

            return low + 1;

        }

        public static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;           
        }
    }
}
