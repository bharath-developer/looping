using System;

namespace primeNumberRange___looping
{
  class Program
  {
    static void Main(string[] args)
    {
      int value1, value2, i, j = 0;
      Console.WriteLine("\n\n");
      Console.WriteLine("Find the prime numbers within a range of numbers :");
      Console.WriteLine("--------------------------------------------------");
      Console.WriteLine("Enter the starting range :");
      value1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the ending range :");
      value2 = Convert.ToInt32(Console.ReadLine());
      for (i = 1; i <= j; i++)
        Console.WriteLine($"The prime number between {value1} and {value2} are : ");
      Console.ReadLine();
    }
  }
}
