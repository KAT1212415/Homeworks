using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book<string, int>[] books1 = new Book<string, int>[]
            {
                new Book<string, int> ("в1", "книга 1", 1601,"Илья"),
                new Book<string, int>("F-1234", "книга 2", 1701, "Артем"),
                new Book<string, int>("в3", "книга 3", 1901, "автор"),
            };
            Book<int, string>[] books2 = new Book<int, string>[]
           {
                new Book<int, string> (21, "книга 25","Период 1","Илья"),
                new Book<int, string>(16, "книга 57", "Период 2", "Артем"),
                new Book<int, string>(42, "книга 46", "Период 3", "автор"),
           };

            Book<string, int> foundBook = Book<string, int>.FindBook(books1, "F-1234");
            Book<int, string> foundBook2 = Book<int, string>.FindBook(books2, 421);
        }
    }
    public class Book<T, U>
    {
     public T Code { get; set; }
     private string Title;
     public U PublicationYear;
     private string Author;

        public Book(T code, string title, U publicationYear, string author)
        {
            Code = code;
            Title=title;
            PublicationYear=publicationYear;
            Author=author;
        }
        public override string ToString()
        {
            return $"{Code} ({typeof(T).Name}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";
        }
        public static Book<T, U> FindBook(Book<T, U>[] books, T Code )
        { foreach ( var book in books ) 
            { 
                if (book.Code.Equals(Code))
                    { 
                    Console.WriteLine($"Книга найдена. Код книги {book.Code}");
                    return book;
                    }
            }
            Console.WriteLine($"Книга с кодом {Code} не найдена.");
            return null;
            
        } 
    }

}
