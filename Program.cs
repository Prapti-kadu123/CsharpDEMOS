
using System;

namespace LibraryManagement
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Console.Write("Welcome !!!\nEnter your password :");
            string password = Console.ReadLine();

            if (password == "prapti")
            {
            }
            else
            {
                Console.WriteLine("Invalid password");
            }

            Library D = new Library(" Welcome To Our LIBRARY *");
            int m = -1;
            while (m!= 0)
            {
                int Choice = -1;
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("\t*   {0}\n", D.LibraryName);
                Console.WriteLine(" *** Please Select Your Choice: ***");
                Console.WriteLine(" |----------------------------|");
                Console.WriteLine(" |----------------------------|");
                Console.WriteLine(" | \t1 Press 1 For 'Librarian' |");
                Console.WriteLine(" | \t2 Press 2 For 'Borrower' |");
                Console.WriteLine(" | \t0 Press 3 For 'Exit' |");
                Console.WriteLine(" |----------------------------|");
                Console.WriteLine(" |----------------------------|");
                
                Console.Write("\tEnter your choice : ");
                
                m = int.Parse(Console.ReadLine());

                switch (m)
                {
                    case 0:
                        Console.WriteLine(" ---** Thank you **----");
                        break;
                    case 1:
                        while (Choice != 0)
                        {
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine(" |**********----------------------------**********|");
                            Console.WriteLine("\t0.| Return to Back");
                            Console.WriteLine("\t1.| Add a Books");
                            Console.WriteLine("\t2.| Display All Books");
                            Console.WriteLine("\t3.| Remove the book");
                            Console.WriteLine("\t4.| Search the book");
                            Console.WriteLine("\t5.| Sorting the Books\n");
                            Console.WriteLine(" |***********----------------------------**********|");
                            Console.WriteLine("----------------------------------");
                            Console.Write("\tEnter your choice : ");
                            Choice = int.Parse(Console.ReadLine());

                            switch (Choice)
                            {
                                case 0:
                                    Console.WriteLine("\t-- Thank You--");
                                    break;
                                case 1:
                                    Console.WriteLine("\t---- Add a books ---");
                                    D.AddBook();
                                    break;
                                case 2:
                                    Console.WriteLine("\t--- Display the books ---");
                                    D.DisplayAllBook();
                                    break;
                                case 3:
                                    Console.WriteLine("\t--- Remove Book ----");
                                    D.RemoveBook();
                                    break;
                                case 4:
                                    Console.WriteLine("\t--- Search Book ----");
                                    D.SearchBook();
                                    break;
                                case 5:
                                    Console.WriteLine("\t--- Sorting Book ----");
                                    D.Sorting();
                                    break;

                            }
                        }

                        break;
                    case 2:
                        int i = -1;
                        while (i != 0)
                        {
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine(" |**************----------------------------****************|");
                            Console.WriteLine("\t0.| Return to Back");
                            Console.WriteLine("\t1.| Issue the book");
                            Console.WriteLine("\t2.| Return the book\n");
                            Console.WriteLine(" |**************----------------------------****************|");
                            Console.WriteLine("----------------------------------");
                            
                            Console.Write("\tEnter your choice : ");
                            i = int.Parse(Console.ReadLine());
                            switch (i)
                            {
                                case 0:
                                    Console.WriteLine("\t--- Thank You---");
                                    break;
                                case 1:
                                   Console.WriteLine("\t-- Issue Book ---");
                                   D.IssueBook();
                                    break;
                                case 2:
                                    Console.WriteLine("\t--- Return Book ---");
                                    D.ReturnBook();
                                    break;
                            }
                        }
                        break;

                }
            }
        }
    }

}