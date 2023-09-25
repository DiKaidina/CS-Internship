using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4
{
    internal class HomeLibrary
    {
        private List<Book> books = new List<Book>();

        // добавить книгу 
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        //удалить книгу
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        // Поиск по автору
        public List<Book> FindByAuthor(string author)
        {
            //сравнение без учета регистра
            return books.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        //по году издания
        public List<Book> FindBooksByYear(int year)
        {
            return books.Where(book => book.Year == year).ToList();
        }

        // сортировка по названию
        public void SortByTitle()
        {
            books = books.OrderBy(book => book.Title).ToList();
        }

        
        public void SortByAuthor()
        {
            books = books.OrderBy(book => book.Author).ToList();
        }

        
        public void SortByYear()
        {
            books = books.OrderBy(book => book.Year).ToList();
        }

        // Метод для вывода всех книг в библиотеке
        public void DisplayAllBooks()
        {
            Console.WriteLine("Список книг в библиотеке:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
