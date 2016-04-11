using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Toto_6_49
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            for (int n1 = 1; n1 <= 44; n1++)
            {
                for (int n2 = n1 + 1; n2 <= 45; n2++)
                {
                    for (int n3 = n2 + 1; n3 <= 46; n3++)
                    {
                        for (int n4 = n3 + 1; n4 <= 47; n4++)
                        {
                            for (int n5 = n4 + 1; n5 <= 48; n5++)
                            {
                                for (int n6 = n5 + 1; n6 <= 49; n6++)
                                {
                                    //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", n1, n2, n3, n4, n5, n6);
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("{0} combinations", counter);
        }
    }
}
