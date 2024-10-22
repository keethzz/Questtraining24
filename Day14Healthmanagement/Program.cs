using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Healthmanagement
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MedicalCondition { get; set; }
    }
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentType { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var patients = new List<Patient>
            {
                new Patient { Id = 1, Name = "John Doe", Age = 45, Gender = "Male", MedicalCondition = "Diabetes" },
                new Patient { Id = 2, Name = "Jane Smith", Age = 60, Gender = "Female", MedicalCondition = "Hypertension" },
                new Patient { Id = 3, Name = "Alice Johnson", Age = 75, Gender = "Female", MedicalCondition = "Heart Disease" }
            };

            var appointments = new List<Appointment>
            {
                new Appointment { Id = 1, PatientId = 1, DoctorName = "Dr. Adams", AppointmentDate = DateTime.Now.AddDays(3), AppointmentType = "Consultation" },
                new Appointment { Id = 2, PatientId = 2, DoctorName = "Dr. Baker", AppointmentDate = DateTime.Now.AddDays(10), AppointmentType = "Follow-up" },
                new Appointment { Id = 3, PatientId = 3, DoctorName = "Dr. Clark", AppointmentDate = DateTime.Now.AddDays(1), AppointmentType = "Consultation" }
            };
        }
    }
}
