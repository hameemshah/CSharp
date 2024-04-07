using System;

namespace MergeSort
{
    public class Program
    {
        void merge(int[] arr, int lb, int ub, int mid)
        {
            int[] merged = new int[ub - lb + 1];
            int i = lb, k = 0, j = mid + 1;
            while (i <= mid && j <= ub)
            {
                if (arr[i] <= arr[j])
                {
                    merged[k] = arr[i];
                    i++;
                }
                else
                {
                    merged[k] = arr[j];
                    j++;
                }
                k++;
            }
            while (i <= mid)
            {
                merged[k] = arr[i];
                i++;
                k++;
            }
            while (j <= ub)
            {
                merged[k] = arr[j];
                j++;
                k++;
            }
            for (i = lb, k = 0; i <= ub; i++, ++k)
            {
                arr[i] = merged[k];
            }
        }
        void sort(int[] arr, int lb, int ub)
        {
            if (lb < ub)
            {
                int mid = (lb + ub) / 2;
                sort(arr, lb, mid);
                sort(arr, mid + 1, ub);
                merge(arr, lb, ub, mid);
            }
        }

        static void print(int[] arr)
        {
            foreach (int num in arr)
                Console.Write(num + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 9, 1, 0, 2, 6, 3, 8, 4, 7 };
            Console.WriteLine("The given array is :");
            print(arr);
            Program obj = new Program();
            obj.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("The sorted array is :");
            print(arr);
        }
    }
}
