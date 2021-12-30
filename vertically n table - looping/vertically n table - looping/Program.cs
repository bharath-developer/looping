using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vertically_n_table___looping
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, value,iteration;
            Console.WriteLine("\n\n");
            Console.WriteLine("Display the multiplication table vertically from 1 to n :");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter the table number :");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  number of iteration table needs to print :");
            iteration = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= iteration; i++)
                Console.WriteLine($"{value} X {i} = {value * i}");
            Console.ReadLine();
        }
    }
}
