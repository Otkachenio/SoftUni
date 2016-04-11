using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Process[] process = Process.GetProcessesByName("firefox");
        process[0].Kill();

    }
}