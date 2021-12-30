using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_odd_sum___looping
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 1, n;
            Console.WriteLine("\n\n");
            Console.WriteLine("Display the n terms of odd numbers :");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter number of terms");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine($"{sum }");
                sum += 2;
            }
            Console.ReadLine();
        }
    }
}
