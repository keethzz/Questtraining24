using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Studentdetails
{
    internal class Mark
    {
        public string SubjectName;
        public int Marks;
        public int MaxMarks;
        public override string ToString()
        {
            return $"Subject: {SubjectName}, Marks Obtained: {Marks}, Max Mark: {MaxMarks}";
        }
    }
}
