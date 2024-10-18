using Day13Bookmanagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Bookmanagement.Services
{
    internal interface ISevice
    {
        void Save(Book book);
        void Delete(string id);
        Book Search(string title);
    }
}
