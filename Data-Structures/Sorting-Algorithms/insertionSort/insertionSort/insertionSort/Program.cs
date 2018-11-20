using System;

namespace insertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Insertion Sort!");

            int[] input = { 76, -65, 234, 81, 1, -923 };

            Console.WriteLine("Your current array: ");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{ input[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine("Insertion Sort: ");

            int[] newArr = InsertionSort(input);

            Console.WriteLine();
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write($"{ newArr[i]} ");
            }
            Console.WriteLine();
        }

        public static int[] InsertionSort(int[] myArray)
        {
            for (int i = 1; i < myArray.Length; i++)
            {
                int temp = myArray[i];
                int j = i - 1;

                while (j >= 0 && temp < myArray[i])
                {
                    myArray[j + 1] = myArray[j];
                    j--;
                }

                myArray[j + 1] = temp;
            }

            return myArray;
        }
    }
}
