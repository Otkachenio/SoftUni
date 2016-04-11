namespace Problem2.AsynchronousTimer
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public sealed class AsyncTimer
    {
        public AsyncTimer(Action action, double ticks, double timeInMilliseconds)
        {
            this.Action = action;
            this.Ticks = ticks;
            this.TimeInMilliseconds = timeInMilliseconds;
        }

        public Action Action { get; set; }

        public double Ticks { get; private set; }

        public double TimeInMilliseconds { get; private set; }

        public void Run()
        {
            CancellationTokenSource cancallation =
                new CancellationTokenSource(TimeSpan.FromMilliseconds(TimeSpanInMilliseconds()));

            RepeatActionEvery(this.Action, 
                TimeSpan.FromMilliseconds(this.TimeInMilliseconds),
                cancallation.Token).Wait();
        }

        public static async Task RepeatActionEvery(Action action, TimeSpan timeInterval,
                                                    CancellationToken cancaletionToken)
        {
            while (true)
            {
                action();
                Task task = Task.Delay(timeInterval, cancaletionToken);

                try
                {
                    await task;
                }
                catch (TaskCanceledException)
                {
                    return;
                }
            }
        }

        private double TimeSpanInMilliseconds()
        {
            double time = this.Ticks * this.TimeInMilliseconds;

            return time;
        }
    }
}