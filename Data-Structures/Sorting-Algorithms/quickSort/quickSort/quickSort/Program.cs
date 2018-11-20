using System;

namespace quickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] myArr = { 76, 7, 1, 65, 99 };

            QuickSort(myArr, 0, myArr.Length-1);
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            int position = Partition(arr, left, right);
        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                low++;
                Swap();
            }

            return 0;
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
