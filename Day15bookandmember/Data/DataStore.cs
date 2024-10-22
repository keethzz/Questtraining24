using Day15bookandmember.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15bookandmember.Data
{
    internal class DataStore
    {
        public static List<Book> Books;
        public static List<Member> Members;

        static DataStore()
        {
            Books = new List<Book>()
            {
                new Book{Id = 1, Name = "Book1"},
                new Book{Id = 2, Name = "Book2"}
            };

            Members = new List<Member>()
            {
                new Member{Id = 1, Name = "Memb1", Email = "memb1@g.com"},
                new Member{Id = 2, Name = "Memb2", Email = "memb2@g.com"}
            };
        }
    }
}
