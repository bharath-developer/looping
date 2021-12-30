using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication___looping
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, value;
            Console.WriteLine("\n\n");
            Console.WriteLine("Display the muliplication table of a given integer :");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter the number :");
            value = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 10; i++)
                Console.WriteLine($"{value} X {i} = {value*i}");
            Console.ReadLine();
        }
    }
}
