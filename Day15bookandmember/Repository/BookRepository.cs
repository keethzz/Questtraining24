using Day15bookandmember.Data;
using Day15bookandmember.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15bookandmember.Repository
{
    internal class BookRepository
    {
        public GenericResponse<List<Book>> GetAllBooks()
        {
            var books = DataStore.Books;
            return new GenericResponse<List<Book>>
            {
                Success = true,
                Data = books,
            };
        }

        public GenericResponse<Book> GetBookById(int id)
        {
            Book book = null;
            foreach (var b in DataStore.Books)
            {
                if (b.Id == id) 
                {
                    book = b;  
                    break;      
                }
            }
            if (book == null)
            {
                return new GenericResponse<Book>
                {
                    Success = false,
                    Message = "Book not found",
                };
            }

            return new GenericResponse<Book>
            {
                Success = true,
                Message="Book found",
                Data = book,
            };
        }
    }
}
