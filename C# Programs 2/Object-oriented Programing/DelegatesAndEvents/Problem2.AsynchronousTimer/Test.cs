namespace Problem2.AsynchronousTimer
{
    using System;

    class Test
    {
        static void Main(string[] args)
        {
            Action act = ProgramTest;

            AsyncTimer timer = new AsyncTimer(act, 20, 500);

            timer.Run();
        }

        public static void ProgramTest()
        {
        Console.WriteLine("Testing: {0}");
        }
    }
}