using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace right_angle_triangle_with_number___looping
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;
            Console.WriteLine("\n\n");
            Console.WriteLine("Display the pattern as right angle triangle using number :");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter number of rows");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write($"{j}");
                Console.Write('\n');
            }
            Console.ReadLine();
        }
    }
}
