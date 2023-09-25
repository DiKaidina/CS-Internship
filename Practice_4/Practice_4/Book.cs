using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public string ToString()
        {
            return $"Название: {Title}, Автор: {Author}, Год издания: {Year}";
        }
    }
}
