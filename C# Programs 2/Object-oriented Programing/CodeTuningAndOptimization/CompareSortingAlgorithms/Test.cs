namespace CompareSortingAlgorithms
{
    using System;
    using System.Diagnostics;

    class Test
    {
        static void Main(string[] args)
        {
            int count = 10000;
            int[] array = new int[count];

            for (int i = 1; i < count; i++)
            {
                array[i] = i;
            }

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Sorter.InsertionSort(array);
            stopwatch.Stop();
            Console.WriteLine("Insertion sort for array with {0} elements - time: {1} seconds",
                count, stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();
            Sorter.SelectionSort(array, count);
            stopwatch.Stop();
            Console.WriteLine("Selection sort for array with {0} elements - time: {1} seconds",
                count, stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();
            Sorter.MergeSort(array);
            stopwatch.Stop();
            Console.WriteLine("Merge sort for array with {0} elements - time: {1} seconds",
                count, stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();
            Sorter.QuickSort(array, 0, count - 1);
            stopwatch.Stop();
            Console.WriteLine("Merge sort for array with {0} elements - time: {1} seconds",
                count, stopwatch.Elapsed);
        }
    }
}