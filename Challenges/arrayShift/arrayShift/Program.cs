using System;

namespace arrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Array Shift!");
            //create parameters for insertShiftArray method
            int[] inputArray = { 2, 4, 6, 8 };
            int value = 5;

            int[] display = insertShiftArray(inputArray, value);
            Console.WriteLine("{{{0}}}", string.Join(", ", display));
        }

        //method that takes in an input array and a value that will be added to the middle of the array
        //output will new array with value inserted in the middle index
        static int[] insertShiftArray(int[] inputArray, int value)
        {
            int[] outputArray = new int[inputArray.Length + 1];

            //decimal data type used in order to round up in case the array length is odd
            decimal middle = inputArray.Length / 2;
            decimal roundedMiddle = Math.Ceiling(middle);
            int counter = 0;

            for (int i = 0; i < outputArray.Length; i++)
            {
                if (i == roundedMiddle)
                {
                    outputArray[i] = value;
                    counter++;
                } else
                {
                    outputArray[i] = inputArray[i - counter];  
                }
            }
            return outputArray;
        }
    }
}
