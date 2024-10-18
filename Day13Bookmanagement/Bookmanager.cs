using Day13Bookmanagement.Entities;
using Day13Bookmanagement.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Bookmanagement
{
    internal class Bookmanager
    {

        public void Add()
        {
            var book = new Book();
            book.Id = Guid.NewGuid().ToString();

            Console.Write("Title: ");
            book.Title = Console.ReadLine();

            Console.Write("Author: ");
            book.Author = Console.ReadLine();

            Console.Write("Title: ");
            book.Title = Console.ReadLine();
            Console.Write("Enter Book Type: 1. Stories 2. Novels: ");
            var bookType = Console.ReadLine();
            book.Type = bookType == "1" ? BookType.Stories : BookType.Novels;
        }

        public void Remove()
        {
            Console.Write("Enter the book ID to remove: ");
            var id = Console.ReadLine();
            
        }

        public void Search()
        {
            Console.Write("Enter the title of the book: ");
            var title = Console.ReadLine();

            
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Delete Book");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Search();
                        break;
                    case "3":
                        Remove();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
    