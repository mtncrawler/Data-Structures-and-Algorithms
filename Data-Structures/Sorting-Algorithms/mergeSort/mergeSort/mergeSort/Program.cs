using System;

namespace mergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Merge Sort!");
            Console.WriteLine();

            Console.WriteLine("Your current array: ");
            int[] arr = { 2, 6, 99, 12, -76, 34, 100, 1 };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            int[] sorted = MergeSort(arr);

            Console.WriteLine("Your merge sorted array: ");
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }

        static int[] MergeSort(int[] myarr)
        {
            if (myarr.Length > 1)
            {
                int leftSize = myarr.Length / 2;
                int rightSize = myarr.Length / 2;

                //first half goes in left arr
                int[] left = new int[leftSize];
                Array.Copy(myarr, 0, left, 0, leftSize);

                //second half goes in right arr
                int[] right = new int[rightSize];
                Array.Copy(myarr, myarr.Length / 2, right, 0, rightSize);

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, myarr);
            }
            return myarr;
        }

        static int[] Merge(int[] left, int[] right, int[] arr)
        {
            //left pointer
            int i = 0;
            //right pointer
            int j = 0;
            //end arr pointer
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }

                k++;
            }

            if (i == left.Length)
            {
                Array.Copy(right, j, arr, k, right.Length - j);
            }
            else
            {
                Array.Copy(left, i, arr, k, left.Length - i);
            }

            return arr;
        }
    }
}
