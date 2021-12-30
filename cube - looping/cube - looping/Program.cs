using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cube___looping
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,value;
            Console.WriteLine("\n\n");
            Console.WriteLine("Display the cube till n numbers:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Enter Number of Terms :");
            value = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= value; i++)
            {
                Console.WriteLine($"Number is : {i} and cube of the {i} is : {i*i*i}");
            }
            Console.ReadLine();
           
        }
    }
}
