using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give seconds: ");
            string line = Console.ReadLine(); // 3661

            int seconds = int.Parse(line);

            int hour = seconds / 3600; // 1
            int min = seconds / 60 - hour * 60;
            int second = seconds % 60; // 1

            Console.WriteLine("Time: {0}h {1}m {2}s", hour, min, second);
        }
    }
}
