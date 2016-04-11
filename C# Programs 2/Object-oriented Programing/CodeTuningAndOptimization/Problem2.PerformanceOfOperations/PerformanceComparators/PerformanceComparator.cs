namespace Problem2.PerformanceOfOperations.PerformanceComparators
{
    using System;

    public abstract class PerformanceComparator
    {
        private int loopsCount;

        public PerformanceComparator(int loopsCount)
        {
            this.LoopsCount = loopsCount;
        }

        protected int LoopsCount
        {
            get
            {
                return this.loopsCount;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Loops count have to be positive number.");
                }

                this.loopsCount = value;
            }
        }

        public abstract void CompareAdd();
                        
        public abstract void CompareSubtract();
                        
        public abstract void CompareIncrementPrefix();
                        
        public abstract void CompareIncrementPostfix();
                        
        public abstract void CompareIncrementAddEqual();
                        
        public abstract void CompareMultiply();
                        
        public abstract void CompareDivide();
    }
}