using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11filedrestriction
{
    internal class NewField
    {
        public string Name { get; set; }
        private int age;
        public int Age {
            get => age;               
            set
            {
                if (value < 4 && value > 80)
                    age = 0;
                else
                    age = value;
            }
        }
    }
}
