using System;

namespace mergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        static void MergeSort(int[] myarr)
        {
            if (myarr.Length > 1)
            {
                int leftSize = myarr.Length / 2;
                int rightSize = myarr.Length / 2;

                int[] left = new int[leftSize];
                Array.Copy(myarr, 0, left, 0, leftSize);

                int[] right = new int[rightSize];
                Array.Copy(myarr, myarr.Length / 2, right, 0, rightSize);

                MergeSort(left);
                MergeSort(right);

                Merge(left, right, myarr);
            }

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
