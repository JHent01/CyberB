using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_1_2
{
    internal class Book
    {

        string Title;

        string Author;


        string Content;
        
        public Book(string title , string author, string content)
        { 
            this.Title = title;
            this.Author = author;
            this.Content = content;
        
        }
        public void Show()
        { 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Назва книги " + Title);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Автор " + Author);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Контекст " + Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
