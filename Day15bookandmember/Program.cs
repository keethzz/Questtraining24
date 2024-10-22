using Day15bookandmember.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15bookandmember
{
    internal class Program
    {           
        static void Main(string[] args)
            {
                var bookRepository = new BookRepository();
                var memberRepository = new MemberRepository();

                var allBooks = bookRepository.GetAllBooks();
                if (allBooks.Success)
                {
                   
                        Console.WriteLine($"{allbooks.Id} {book.Name}");
                   
                }

                var bookResult = bookRepository.GetBookById(1);
                if (bookResult.Success)
                {
                    Console.WriteLine($"Found Book: {bookResult.Name}");
                }
                else
                {
                    Console.WriteLine(bookResult.Message);
                }

                var allMembers = memberRepository.GetAllMembers();
                
        }
    }
}
