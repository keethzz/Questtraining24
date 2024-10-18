using Day13Bookmanagement.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Bookmanagement.Entities
{
    internal class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public BookType Type { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"{Title} by {Author} in {Type} having {Id})";
        }
    }
}
