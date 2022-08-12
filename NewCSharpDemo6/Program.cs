using System;

namespace NewCSharpDemo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string val;
                int res;

                Console.WriteLine("Input from user: ");
                val = Console.ReadLine();

                // convert to integer
                res = Convert.ToInt32(val);

                // display the line
                Console.WriteLine("Input = {0}", res);
            }

        }
    }
