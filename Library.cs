using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LibraryManagement
{
    internal class Library
    {
        static List<Book> bookList = new List<Book>();
        //static List<BorrowDetails> borrowList = new List<BorrowDetails>();
        static Book book = new Book();
        //static BorrowDetails borrow = new BorrowDetails();


        // Aggregated Collection of Objects
        private ArrayList books;




        public string LibraryName { get; private set; }

        public Library(string name)
        {
            this.LibraryName = name;
            books = new ArrayList();
        }

        public void AddBook()
        {
            Book book = new Book();

            Console.WriteLine();
            Console.WriteLine("Enter the details of the Book");
            Console.Write("Book Name : ");
            book.BookName = Console.ReadLine();
            Console.Write("BookPrice : ");
            book.BookPrice = int.Parse(Console.ReadLine());
            Console.Write("BookCount : ");
            book.BookCount = decimal.Parse(Console.ReadLine());

            this.books.Add(book);                         // boxing
        }

        public void RemoveBook()
        {
            this.DisplayAllBook();
            Console.WriteLine("Enter the ID of the product to remove:");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < books.Count; i++)
            {
                Book p = this.books[i] as Book;        // unboxing
                if (p.BookId == id)
                {
                    this.books.Remove(p);
                    break;          // exit the for loop
                }
            }

        }

        public void DisplayAllBook()
        {
            Console.WriteLine();
            Console.WriteLine($"List of Products in {this.LibraryName.ToUpper()}:");
            Console.WriteLine("{0,5} {1,-20} {2,5} {3,15} {4, 15}", "BookID", "BookName", "BookPrice", "BookCount", "Cost");

            foreach (Book p in this.books)
            {
                Console.WriteLine(p);
            }
        }

        public void SearchBook()
        {
            Book book = new Book();
            this.DisplayAllBook();
            Console.Write("Search by BOOK ID :");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < books.Count; i++)
            {
                foreach (Book searchId in books)
                {
                    if (searchId.BookId == id)
                    {
                        Console.WriteLine("Book Id :{0}\t" + "Book name :{1}\t" +"Book price :{2}\t" +"Book Count :{3}\t" +"Cost :{4}", searchId.BookId, searchId.BookName, searchId.BookPrice, searchId.BookCount, searchId.Cost);
                    }
                }



            }
        }

        public void Sorting()
        {
            this.DisplayAllBook();

            Console.WriteLine("---- After Sorting Elements:\n");

            this.books.Sort();

            foreach (Book p in this.books)
            {
                Console.WriteLine(p.ToString());
            }

        }


        public void ReturnBook()
        {
            this.DisplayAllBook();
            Book b = new Book();
            Console.Write("\tUser id : ");
            b.UserId = int.Parse(Console.ReadLine());
            Console.Write("\tUser Name : ");
            b.UserName = Console.ReadLine();
            Console.Write("\n\tEnter the Id of the Book to return: ");
            int id = int.Parse(Console.ReadLine());
            bool found = false;


            for (int i = 0; i < books.Count; i++)
            {
                Book B = this.books[i] as Book;
                if (B.BookId == id)
                {
                    Console.Write("\tEnter how many count of this book you want return : ");
                    B.borrowCount = int.Parse(Console.ReadLine());
                    B.BookCount = B.BookCount + B.borrowCount;

                    Console.WriteLine("Book id: {0} \t" + "Book name: {1} \t\t" + "Book price: {2}\t\t" + "Book Count  : {3}\t"+ "cost:{4}\t" + "User Id: {5}\t" + "User Name: {6}",
                    B.BookId, B.BookName, B.BookPrice, B.BookCount, B.Cost, b.UserId, b.UserName);
                    DateTime dateTime = DateTime.Now;
                    Console.WriteLine("Return book Date is: {0}", dateTime);
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine("\tNot found");
            }

        }

        public void IssueBook()
        {
            this.DisplayAllBook();
            Book b = new Book();
            Console.Write("\tUser id : ");
            b.UserId = int.Parse(Console.ReadLine());
            Console.Write("\tUser Name : ");
            b.UserName = Console.ReadLine();
            Console.Write("\n\tEnter the Id of the Book to issue: ");
            int id = int.Parse(Console.ReadLine());
            bool found = false;


            for (int i = 0; i < books.Count; i++)
            {
                Book B = this.books[i] as Book;
                if (B.BookId == id)
                {
                    Console.Write("\tEnter how many count of this book you want issue : ");
                    B.borrowCount = int.Parse(Console.ReadLine());
                    B.BookCount = B.BookCount - B.borrowCount;

                    Console.WriteLine("Book id: {0} \t" + "Book name: {1} \t\t" + "Book price: {2}\t\t" + "Book Count  : {3}\t"+ "cost:{4}\t" + "User Id: {5}\t" + "User Name: {6}",
                    B.BookId, B.BookName, B.BookPrice, B.BookCount, B.Cost, b.UserId, b.UserName);
                    DateTime dateTime = DateTime.Now;
                    Console.WriteLine("Issue book Date is: {0}", dateTime);
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine("\tNot found");
            }
        
        


    }

    }
}



       
                        
        
    
           

        
    
                

            
        
    



            
        
    

    

           








            
        
    

        
    








            
    



