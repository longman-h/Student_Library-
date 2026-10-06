using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Book
    {
      
        private string _title;
        private string _author;
        private string _isbn;

        public string Title { get => _title; private set => _title = value; }

        public string Author
        {
            get => _author;
            set
            {
                if (!string.IsNullOrEmpty(value) && !value.Any(char.IsDigit))
                {
                    _author = value;
                }
                else
                {
                    Console.WriteLine("Author name cannot contain numbers.");
                }
            }
        }

        public string ISBN
        {
            get => _isbn;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 8 && value.All(char.IsDigit))
                {
                    _isbn = value;
                }
                else
                {
                    Console.WriteLine("ISBN must be an 8-digit number.");
                }
            }
        }

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
