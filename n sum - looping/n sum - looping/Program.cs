using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_sum___looping
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.WriteLine("\n\n");
            Console.WriteLine("Display n terms of natural number and their sum :");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter the starting value :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The first {n} natural number is :");
            for (i = 1; i<= n; i++)
            {
                Console.WriteLine($"{i}");
                sum += i;
            }
            Console.WriteLine($"The sum of natural number up to {n} terms :{sum}");
            Console.ReadLine();
        }
    }
}
