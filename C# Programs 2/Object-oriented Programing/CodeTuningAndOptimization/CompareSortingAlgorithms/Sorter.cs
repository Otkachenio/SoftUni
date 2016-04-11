namespace CompareSortingAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public static class Sorter
    {
        public static void InsertionSort(int[] intArray)
        {
            int temp, j;
            for (int i = 1; i < intArray.Length; i++)
            {
                temp = intArray[i];
                j = i - 1;

                while (j >= 0 && intArray[j] > temp)
                {
                    intArray[j + 1] = intArray[j];
                    j--;
                }

                intArray[j + 1] = temp;
            }
        }

        public static void SelectionSort(int[] dataset, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                int min = i;
                for (j = i + 1; j < n; j++)
                    if (dataset[j] < dataset[min]) min = j; //find min value
                                                            //then swap it with the beginning item of the unsorted list
                int temp = dataset[i];
                dataset[i] = dataset[min];
                dataset[min] = temp;
            }

        }

        public static int[] MergeSort(int[] array)
        {
            // If list size is 0 (empty) or 1, consider it sorted and return it
            // (using less than or equal prevents infinite recursion for a zero length array).
            if (array.Length <= 1)
            {
                return array;
            }

            // Else list size is > 1, so split the list into two sublists.
            int middleIndex = (array.Length) / 2;
            int[] left = new int[middleIndex];
            int[] right = new int[array.Length - middleIndex];

            Array.Copy(array, left, middleIndex);
            Array.Copy(array, middleIndex, right, 0, right.Length);

            // Recursively call MergeSort() to further split each sublist
            // until sublist size is 1.
            left = MergeSort(left);
            right = MergeSort(right);

            // Merge the sublists returned from prior calls to MergeSort()
            // and return the resulting merged sublist.
            return Merge(left, right);
        }

        public static int[] Merge(int[] left, int[] right)
        {
            // Convert the input arrays to lists, which gives more flexibility 
            // and the option to resize the arrays dynamically.
            List<int> leftList = left.OfType<int>().ToList();
            List<int> rightList = right.OfType<int>().ToList();
            List<int> resultList = new List<int>();

            // While the sublist are not empty merge them repeatedly to produce new sublists 
            // until there is only 1 sublist remaining. This will be the sorted list.
            while (leftList.Count > 0 || rightList.Count > 0)
            {
                if (leftList.Count > 0 && rightList.Count > 0)
                {
                    // Compare the 2 lists, append the smaller element to the result list
                    // and remove it from the original list.
                    if (leftList[0] <= rightList[0])
                    {
                        resultList.Add(leftList[0]);
                        leftList.RemoveAt(0);
                    }

                    else
                    {
                        resultList.Add(rightList[0]);
                        rightList.RemoveAt(0);
                    }
                }

                else if (leftList.Count > 0)
                {
                    resultList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }

                else if (rightList.Count > 0)
                {
                    resultList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }

            // Convert the resulting list back to a static array
            int[] result = resultList.ToArray();
            return result;
        }

        static public void QuickSort(int[] arr, int left, int right)
        {
            // For Recusrion
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    QuickSort(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort(arr, pivot + 1, right);
            }
        }

        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }        
    }
}