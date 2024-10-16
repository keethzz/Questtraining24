using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Studentdetails
{
    internal class Student
    {
        public string Name;
        public string Class;
        public string RegNo;
        public Mark StudentMark;

        public override string ToString()
        {
            return $"Name: {Name}\n Class: {Class} \n Reg No: {RegNo}";
        }
    }
}
