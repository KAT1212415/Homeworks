using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Название","Автор", 1987, 136);
            book.GetInfo();
        }
    }
    internal class Book
    {
        private string _title;
        private string _author;

        private int _Year { get; set; }

        private int _Pages { get; set; }

        public Book(string title, string author, int year, int pages)
        {
            _title = title;
            _author = author;
            _Year = year;
            _Pages = pages;
          
        }

        public void GetInfo()
            {
            Console.WriteLine($"{_title},{_author},{_Year},{_Pages}");
        }
    }
}
