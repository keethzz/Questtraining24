﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16ContactAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new ContactManager();
            app.AddContact();
            app.GetAllContacts();
        }
    }
}
