using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesmet2machinecode.Entities
{
    internal class Doctor
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string Specialization { get; set; }
        public int PatientId { get; set; }
    }
}
