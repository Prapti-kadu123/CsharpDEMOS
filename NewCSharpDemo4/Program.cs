using System;

namespace NewCSharpDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("It is an Even Number");
                Console.Read();
            }
            else
            {
                Console.WriteLine("It is an Odd Number");
                Console.Read();
            }
        }
    }
}
