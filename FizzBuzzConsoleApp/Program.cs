using System;

namespace FizzBuzzConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("else if way");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("string way");
            for (int i = 1; i <= 100; i++)
            {
                string s = "";
                if (i % 3 == 0)
                {
                    s += "Fizz";
                }
                if (i % 5 == 0)
                {
                    s += "Buzz";
                }
                if (s.Length == 0)
                {
                    s = i.ToString();
                }
                Console.WriteLine(s);
            }
            Console.WriteLine("FizzBuzz answers c#, Press a key to close..");
            Console.ReadKey(true);
        }
    }
}
