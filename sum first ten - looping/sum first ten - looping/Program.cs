using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_first_ten___looping
{
    class Program
    {
        static void Main(string[] args)
        {
            int j , sum =0;
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter the sum of first 10 natural numbers:\n");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("The first 10 natural number is:");
            for (j = 1; j <= 10; j++)
            {
                sum = sum + j;
                Console.Write("{0} \n", j);
            }
            Console.WriteLine($"The sum is : {sum}");
            Console.ReadLine();
        }
    }
}
