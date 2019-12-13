﻿using System;

namespace binarySearch
{
    public class Program
    {
        //display the input array and target then the result of the BinarySearch method
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Binary Search Extraordinaire!");
            int[] input = { 4, 8, 15, 16, 23, 42 };
            int target = 15;
            Console.WriteLine("{{{0}}}", string.Join(", ", input));
            Console.WriteLine($"Locate battleship {target}.");
            Console.WriteLine($"Battleship sunk at index {BinarySearch(input, target)}!");
        }

        //method that uses binary search to find the index of a target in a sorted array
        public static int BinarySearch(int[] input, int target)
        {
            int max = input.Length - 1;
            int min = 0;

            while( min <= max)
            {
                int middle = (min + max)/2;
                if (target == input[middle])
                {
                    return middle;
                }
                else if (target < input[middle])
                {
                    max = middle - 1;
                }
                else
                {
                    min = middle + 1;
                }
            }

            return -1;
        } 
    }
}
