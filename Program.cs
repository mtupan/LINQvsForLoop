using System;
using System.Diagnostics;
using System.Linq;

namespace PerformanceTest
{
    class Program
    {
        static void Main()
        {
            long totalLinq = 0;
            long totalFor = 0;

            for (int i = 0; i < 100; i++)
            {
                var items = Enumerable.Range(1, 1_000_000);

                var sw = Stopwatch.StartNew();
                var resultLinq = items.Where(x => x % 2 == 0).ToList();
                sw.Stop();
                totalLinq += sw.ElapsedMilliseconds;

                sw.Restart();

                var resultFor = new int[resultLinq.Count];
                int index = 0;
                foreach (var item in items)
                {
                    if (item % 2 == 0)
                    {
                        resultFor[index++] = item;
                    }
                }

                sw.Stop();
                totalFor += sw.ElapsedMilliseconds;
            }

            Console.WriteLine($"LINQ total: {totalLinq} ms");
            Console.WriteLine($"LINQ average: {totalLinq / 100.0:F2} ms");

            Console.WriteLine($"For-loop total: {totalFor} ms");
            Console.WriteLine($"For-loop average: {totalFor / 100.0:F2} ms");
        }
    }
}
