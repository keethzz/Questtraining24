using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day15Genericdatatype
{

    class SortedList<T> 
    {
        private List<T> data = new List<T>();

        public int Count => data.Count;

        public void Add(T item)
        {
            data.Add(item);
            data.Sort();

        }
    }

    internal class Program
    {
        static void Main()
        {

        }
    }


}