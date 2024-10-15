using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10manyclass
{
    internal class Student
    {
        public string Name;
        public int Mark1;
        public int Mark2;
        public int Mark3;

        public int TotalMarks()
        {
            return Mark1+Mark2+Mark3;
        }
    }
}
