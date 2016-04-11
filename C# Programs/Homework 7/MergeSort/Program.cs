using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeSortArray
    {
        void mergeArray(int[] arr, int start, int mid, int end)
        {
            int[] temp = new int[end - start + 1];

            int i = start, j = mid + 1, k = 0;
            while (i <= mid && j <= end)
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    k++;
                    j++;
                }
            }
            while (i <= mid)
            {
                temp[k] = arr[i];
                k++;
                i++;
            }
            while (j <= end)
            {
                temp[k] = arr[j];
                k++;
                j++;
            }

            k = 0;
            i = start;
            while (k < temp.Length && i <= end)
            {
                arr[i] = temp[k];
                i++;
                k++; 
            }
        }
        void mergesort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (end + start) / 2;
                mergesort(arr, start, mid);
                mergesort(arr, mid + 1, end);
                mergeArray(arr, start, mid, end);
            }
        }
            static void Main(string[] args)
        {
            int[] arr = { 5, 1, 2, 3, 6, 4, 11, 9, 5, 14 };

            MergeSortArray merge = new MergeSortArray();

            merge.mergesort(arr, 0, arr.Length - 1);

            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }

        }
    }
}
