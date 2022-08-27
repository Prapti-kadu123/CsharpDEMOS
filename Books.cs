using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement
{
     
        internal class Book : System.IComparable
        { 

        static Book book = new Book();
        static List<Book> bookList = new List<Book>();
        private static int bookIdCounter;
        
        static Book()
        {
            Book.bookIdCounter = 1;
        }

        public Book()
        {
            this._BookId = ++Book.bookIdCounter;
        }

        private int _BookId;
        public int BookId
        {
            get
            {
                return _BookId;
            }
        }

       
        public string BookName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int BookPrice { get; set; }

        public decimal BookCount { get; set; }

        public decimal Cost
        {
            get
            {
                return BookPrice * BookCount;
            }
        }

        public decimal borrowCount { get; internal set; }

        public int CompareTo(object obj)
        {
            if (obj != null)
            {
                return 1;
            }
            else
            {
                Book otherbook = (Book)obj;
                return this.BookName.CompareTo(otherbook.BookName);

            }
        }
        public override string ToString()
        {
            return $"{BookId,5} {BookName,-20} {BookPrice,5} {BookCount,15} {Cost,15}";
        }
    }
}

