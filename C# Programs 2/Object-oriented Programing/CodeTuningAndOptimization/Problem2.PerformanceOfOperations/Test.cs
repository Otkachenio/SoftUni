namespace Problem2.PerformanceOfOperations
{
    using System;

    using PerformanceOfOperations.PerformanceComparators;

    public class Test
    {
        static void Main(string[] args)
        {
            IntComparator intComparator = new IntComparator(100000000);
            intComparator.CompareAdd();
            intComparator.CompareSubtract();
            intComparator.CompareIncrementAddEqual();
            intComparator.CompareIncrementPostfix();
            intComparator.CompareIncrementPrefix();
            intComparator.CompareMultiply();
            intComparator.CompareDivide();
        }
    }
}