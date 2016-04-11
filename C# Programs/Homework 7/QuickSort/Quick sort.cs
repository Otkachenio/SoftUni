using System;

class Program
{
    static void Swap(int[] arr, int a, int b)
    {
        int t = arr[a];
        arr[a] = arr[b];
        arr[b] = t;
    }

    static int partition(int[] arr, int start, int end)
    {
        int pivot = arr[end];
        int partitionIndex = start;
        for (int i = start; i < end; i++)
        {
            if (arr[i] <= pivot)
            {
                Swap(arr, i, partitionIndex);
                partitionIndex++;
            }
        }
        Swap(arr, partitionIndex, end);
        return partitionIndex;
    }
    static void quickSort(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int partitionIndex = partition(arr, start, end);
            quickSort(arr, start, partitionIndex - 1);
            quickSort(arr, partitionIndex + 1, end);
        }

    }

    static void Main()
    {
        int[] arr = { 3, 5, 4, 1, 2 };

        quickSort(arr, 0, arr.Length - 1);

        foreach (var e in arr)
        {
            Console.Write(e + " ");
        }
    }
}