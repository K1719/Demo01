using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give your age: ");
            string line = Console.ReadLine(); // "50"
            int age = int.Parse(line); // 50
            if (age < 18)
            {
                Console.WriteLine("You are underaged.");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }
        }
    }
}
