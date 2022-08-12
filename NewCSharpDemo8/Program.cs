using System;

namespace NewCSharpDemo8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the name: ");
            String name = Console.ReadLine();
            Console.WriteLine();

            DateTime datetime = DateTime.Now;
            Console.WriteLine("Today is: {0}", datetime);
            Console.ReadLine();
            Console.WriteLine();

        }
    }
}


