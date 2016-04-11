namespace Problem2.PerformanceOfOperations.PerformanceComparators
{
    using System;
    using System.Diagnostics;

    public class IntComparator : PerformanceComparator
    {
        public IntComparator(int loopsCount = 1000) : base(loopsCount)
        {
        }

        public override void CompareAdd()
        {
            int sum = 0;
            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < this.LoopsCount; i++)
            {
                sum = i + i;
            }
            watch.Stop();
            Console.WriteLine("Int add for {0} loops takes {1} seconds",
                this.LoopsCount, watch.Elapsed);
        }

        public override void CompareSubtract()
        {
            int sum = 0;
            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < this.LoopsCount; i++)
            {
                sum++;
            }
            watch.Stop();
            Console.WriteLine("Int substract for {0} loops takes {1} seconds",
                this.LoopsCount, watch.Elapsed);
        }                  

        public override void CompareIncrementPrefix()
        {
            int sum = 0;
            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < this.LoopsCount; i++)
            {
                ++sum;
            }
            watch.Stop();
            Console.WriteLine("Int increment with prefix for {0} loops takes {1} seconds",
                this.LoopsCount, watch.Elapsed);
        }

        public override void CompareIncrementPostfix()
        {
            int sum = 0;
            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < this.LoopsCount; i++)
            {
                sum++;
            }
            watch.Stop();
            Console.WriteLine("Int increment with postfix for {0} loops takes {1} seconds",
                this.LoopsCount, watch.Elapsed);
        }

        public override void CompareIncrementAddEqual()
        {
            int sum = 0;
            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < this.LoopsCount; i++)
            {
                sum += i;
            }
            watch.Stop();
            Console.WriteLine("Int increment with add equal (+=) for {0} loops takes {1} seconds",
                this.LoopsCount, watch.Elapsed);
        }

        public override void CompareMultiply()
        {
            int sum = 0;
            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < this.LoopsCount; i++)
            {
                sum = i * i;
            }
            watch.Stop();
            Console.WriteLine("Int multiply for {0} loops takes {1} seconds",
                this.LoopsCount, watch.Elapsed);
        }

        public override void CompareDivide()
        {
            int sum = 0;
            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < this.LoopsCount; i++)
            {
                sum = i - i;
            }
            watch.Stop();
            Console.WriteLine("Int divide for {0} loops takes {1} seconds",
                this.LoopsCount, watch.Elapsed);
        }
    }
}