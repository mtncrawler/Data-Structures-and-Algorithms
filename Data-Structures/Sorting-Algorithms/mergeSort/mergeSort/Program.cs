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
            if (myarr.Length > 1 )
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
            int i = 0;
            int j = 0;
            int k = 0;


        }
}
